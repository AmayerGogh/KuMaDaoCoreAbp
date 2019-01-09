using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Events.Bus;
using KuMaDaoCoreAbp.Articles.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KuMaDaoCoreAbp.Web;
using KuMaDaoCoreAbp.Categories;
using Amayer.Express;
using KuMaDaoCoreAbp.Articles.Authorization;
using Abp.Application.Services;

namespace KuMaDaoCoreAbp.Articles
{
    /// <summary>
    /// 
    /// </summary>
    [AbpAuthorize(ArticleAppPermissions.Article)]
    public class ArticleAppService : KuMaDaoCoreAbpAppServiceBase, IArticleAppService
    {
        //private readonly IRepository<Article, long> _articleRepository;
        private readonly IArticleRepository _articleRepository;
        private readonly ArticleManager _articleManage;
        private readonly IRepository<Categories.Category,long> _categoryRespository;
        private readonly IRepository<ArticleDetail, long> _articleDetailRepository;
        private readonly IRepository<ArticleLabel, long> _articleLabelRepository;
        private IEventBus EventBus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="articleRepository"></param>
        /// <param name="articleDetailRepository"></param>
        /// <param name="categoryRepository"></param>
        /// <param name="articleManage"></param>
        public ArticleAppService(IArticleRepository articleRepository,
                                 IRepository<ArticleDetail, long> articleDetailRepository,
                                // IRepository<ArticleLabel, long> articleLabelRepository,
                                IRepository<Categories.Category, long> categoryRepository,
                                 ArticleManager articleManage)
        {
            _articleRepository = articleRepository;
            _articleDetailRepository = articleDetailRepository;
            _categoryRespository = categoryRepository;
         //   _articleLabelRepository = articleLabelRepository;
            _articleManage = articleManage;
            this.EventBus = NullEventBus.Instance;
        }

        private IQueryable<Article> _articleRepositoryAsNoTrack => _articleRepository.GetAll().AsNoTracking();
        #region 文章管理

        /// <summary>
        /// 根据查询条件获取文章分页列表
        /// </summary>
        /// 
        [AbpAllowAnonymous]
        public async Task<BsTableResponseModel<ArticleListDto>> GetPagedArticlesAsync(BsTableRequestModel param)
        {

            var predicate =  _articleManage.GetListAsync(param);
            var query = await _articleRepositoryAsNoTrack.WhereParamAsync(predicate);
            var count = query.Count();

            var list = query
               .OrderByDescending(m => m.Id)
               .Skip(param.offset)
               .Take(param.limit)
               .ToList();
            var listDtos = list.MapTo<List<ArticleListDto>>();

            var cateIds = listDtos.Select(m => m.CategoryId).ToList();
            var cateList = _categoryRespository.GetAllList(m => m.Type ==(int)EnumCategoryType.文章);

            var ids = listDtos.Select(m => m.Id).ToList();
            var articleDetailList =_articleDetailRepository.GetAllList(m => ids.Contains(m.ArticleId));
            foreach (var item in listDtos)
            {
                item.CategoryName = cateList.FirstOrDefault(m => m.Id == item.CategoryId)?.Name;
                item.ArticleDetail = articleDetailList.Where(m => m.ArticleId == item.Id).Select(m=> new ArticleListDto_Detail {
                    Id =m.Id,
                    IsDefault=m.IsDefault
                }).ToList();
            }
            return new BsTableResponseModel<ArticleListDto>()
            {
                rows = listDtos,
                total = count
            };


            //var tgs = _articleRepository.GetAll().AsNoTracking().OrderBy(m => m.Id).Skip(param.offset).Take(10);
            //var stgs = _articleRepository.GetAll().AsNoTracking().OrderBy(m => m.Id).Skip(param.offset).Take(10).ToList();
            //var stssgs = await _articleRepository.GetAll().AsNoTracking().OrderBy(m => m.Id).Skip(param.offset).Take(10).ToListAsync();




        }

        /// <summary>
        /// 通过Id获取文章信息进行编辑或修改 
        /// </summary>
        public async Task<ArticleEditDto> GetArticleForEditAsync(NullableIdDto<long> input)
        {

            ArticleEditDto articleEditDto;

            if (input.Id.HasValue)
            {
                var entity = await _articleRepository.GetAsync(input.Id.Value);
                return articleEditDto = entity.MapTo<ArticleEditDto>();
            }
            else
            {
                return articleEditDto = new ArticleEditDto();
            }



        }


        /// <summary>
        /// 通过指定id获取文章ListDto信息
        /// </summary>
        public async Task<ArticleListDto> GetArticleByIdAsync(EntityDto<long> input)
        {
            var entity = await _articleRepository.GetAsync(input.Id);

            return entity.MapTo<ArticleListDto>();
        }







        /// <summary>
        /// 新增或更改文章
        /// </summary>
        public async Task CreateOrUpdateArticleAsync(ArticleEditDto input)
        {
            try
            {
                if (input.Id.HasValue)
                {
                    await UpdateArticleAsync(input);
                }
                else
                {
                    await CreateArticleAsync(input);
                }
            }
            catch (Exception e)
            {
                var c = e;
                throw;
            }
          
        }

        /// <summary>
        /// 新增文章
        /// </summary>
        //[AbpAuthorize(ArticleAppPermissions.Article_CreateArticle)]
        public virtual async Task<ArticleEditDto> CreateArticleAsync(ArticleEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            var entity = input.MapTo<Article>();

            entity = await _articleRepository.InsertAsync(entity);
            return entity.MapTo<ArticleEditDto>();
        }

        /// <summary>
        /// 编辑文章
        /// </summary>
        //[AbpAuthorize(ArticleAppPermissions.Article_EditArticle)]
        public virtual async Task UpdateArticleAsync(ArticleEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _articleRepository.GetAsync(input.Id.Value);
            input.MapTo(entity);

            await _articleRepository.UpdateAsync(entity);
        }

        /// <summary>
        /// 删除文章
        /// </summary>
        //[AbpAuthorize(ArticleAppPermissions.Article_DeleteArticle)]
        public async Task DeleteArticleAsync(EntityDto<int> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _articleRepository.DeleteAsync(input.Id);
        }

        /// <summary>
        /// 批量删除文章
        /// </summary>
        //[AbpAuthorize(ArticleAppPermissions.Article_DeleteArticle)]
        public async Task BatchDeleteArticleAsync(List<long> input)
        {
            //TODO:批量删除前的逻辑判断，是否允许删除
            await _articleRepository.DeleteAsync(s => input.Contains(s.Id));
        }

        #endregion
        #region 文章内容管理
        /// <summary>
        /// 获取文章内容
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ArticleDetailEditDto> GetArticleDetailByArticleIdAsync(EntityDto<long> input)
        {
           
            var entity = await _articleDetailRepository.FirstOrDefaultAsync(m => m.ArticleId == input.Id);

            if (entity == null)
            {
                entity = new ArticleDetail(input.Id);
                entity.Id  = await _articleDetailRepository.InsertAndGetIdAsync(entity);
            }         
            return entity.MapTo<ArticleDetailEditDto>();
        }

        /// <summary>
        /// 编辑文章内容
        /// </summary>
        //[AbpAuthorize(ArticleAppPermissions.Article_EditArticle)]
        public virtual async Task CreateOrUpdateArticleDetailAsync(ArticleDetailEditDto input)
        {

            var entity = await _articleDetailRepository.GetAsync(input.Id);
            //input.MapTo(entity);
            entity.ArticleId = input.ArticleId;
            entity.Body = input.Body;
            await _articleDetailRepository.UpdateAsync(entity);
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public void TestEvent()
        {
            EventBus.Trigger(new ArticleEventData { Article = new Article { } });
        }

    }
}
