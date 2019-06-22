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
using Abp.Dapper.Repositories;
using Amayer.Express;

namespace KuMaDaoCoreAbp.Articles
{
    /*
               +-->ArticleDetail ...
               |
        Article+-->ArticleDetail  ...
               |
               +-->Label ...
               |
               +-->Label ...
               |
               +-->File ...
      */
    //[AbpAuthorize(ArticleAppPermissions.Article)]
    /// <summary></summary>
    public class ArticleAppService : KuMaDaoCoreAbpAppServiceBase, IArticleAppService
    {
        //private readonly IRepository<Article, long> _articleRepository;
        private readonly IArticleRepository _articleRepository;
        private readonly ArticleManager _articleManage;
        private readonly IRepository<Categories.Category, long> _categoryRespository;
        private readonly IRepository<ArticleDetail, long> _articleDetailRepository;
        //private readonly IRepository<ArticleLabel, long> _articleLabelRepository;

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
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [AbpAllowAnonymous]

        public async Task<BsTableResponseModel<ArticleListDto>> PagedArticlesAsync(BsTableRequestModel param)
        {
            //文章摘要
            var predicate = _articleManage.GetListPredicate(param);
            var query = _articleRepositoryAsNoTrack.WhereParam(predicate);
            var count = 0;
            var listDtos = await Task.Run(() =>
            {
                count= query.Count();
                return query
               .OrderByDescending(m => m.Id)
               .Skip(param.offset)
               .Take(param.limit).MapTo<List<ArticleListDto>>();
            });          
            
            //文章分类
            //var cateIds = listDtos.Select(m => m.CategoryId).ToList();
            //var cateList = _categoryRespository.GetAllList(m => m.Type ==(int)EnumCategoryType.文章);
            //文章分支
            var ids = listDtos.Select(m => m.Id).ToList();
            var articleDetailList = _articleDetailRepository.GetAllList(m => ids.Contains(m.ArticleId)).Select(m => new ArticleListDto_Detail
            {
                Id = m.Id,
                IsDefault = m.IsDefault,
                ArticleId =m.ArticleId
            });
            //组合
            foreach (var item in listDtos)
            {
                //item.CategoryName = cateList.FirstOrDefault(m => m.Id == item.CategoryId)?.Name;
                item.ArticleDetail = articleDetailList.Where(m => m.ArticleId == item.Id).ToList();
            }
            return new BsTableResponseModel<ArticleListDto>()
            {
                rows = listDtos,
                total = count
            };
        }

        /// <summary>
        /// 通过Id获取文基本信息 (过时)
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
        /// 通过Id获取文基本信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ArticleForEditDto> GetArticleForEditAsync2(NullableIdDto<long> input)
        {
            if (!input.Id.HasValue)
            {
                return null;
            }
            var entity = await _articleRepository.GetAsync(input.Id.Value);
            var dto = entity.MapTo<ArticleForEditDto>();

            //文章分支
            var articleDetailList = _articleDetailRepository.GetAllList(m => m.ArticleId == input.Id).Select(m => new ArticleListDto_Detail
            {
                Id = m.Id,
                IsDefault = m.IsDefault,
                ArticleId = m.ArticleId
            }).ToList();
            dto.ArticleDetail = articleDetailList;
            return dto;
        }

        /// <summary>
        /// 通过id获取文章基本信息 (过时)
        /// </summary>
        public async Task<ArticleListDto> GetArticleByIdAsync(EntityDto<long> input)
        {
            var entity = await _articleRepository.GetAsync(input.Id);
            var dto = entity.MapTo<ArticleListDto>();

            //文章分支          
            var articleDetailList = _articleDetailRepository.GetAllList(m => m.ArticleId == input.Id).Select(m => new ArticleListDto_Detail
            {
                Id = m.Id,
                IsDefault = m.IsDefault,
                ArticleId = m.ArticleId
            }).ToList();
            dto.ArticleDetail = articleDetailList;
            return dto;
        }







        /// <summary>
        /// 新增或更改文章
        /// </summary>
        public async Task CreateOrUpdateArticleAsync(ArticleEditDto input)
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

        /// <summary>
        /// 新增文章
        /// </summary>
        //[AbpAuthorize(ArticleAppPermissions.Article_CreateArticle)]
        async Task<ArticleEditDto> CreateArticleAsync(ArticleEditDto input)
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
        async Task UpdateArticleAsync(ArticleEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _articleRepository.GetAsync(input.Id.Value);
            ObjectMapper.Map(input, entity);
            //input.MapTo(entity);

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
        /// 批量删除文章 (有问题)
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
        /// 获取文章内容  若没有当前文章的内容 会自动创建文章内容并返回
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>        
        public async Task<ArticleDetailEditDto> GetArticleDetailByArticleIdAsync(EntityDto<long> input)
        {

            var entity = await _articleDetailRepository.FirstOrDefaultAsync(m => m.ArticleId == input.Id);

            if (entity == null)
            {
                entity = new ArticleDetail(input.Id);
                entity.Id = await _articleDetailRepository.InsertAndGetIdAsync(entity);
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
