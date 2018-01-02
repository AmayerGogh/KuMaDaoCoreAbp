using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Events.Bus;
using KuMaDaoCoreAbp.Article.Dto;
using KuMaDaoCoreAbp.Articles.Authorization;
using KuMaDaoCoreAbp.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KuMaDaoCoreAbp.Articles
{
    //[AbpAuthorize(ArticleAppPermissions.Article)]
    public class ArticleAppService : KuMaDaoCoreAbpAppServiceBase, IArticleAppService
    {
        //private readonly IRepository<Article, long> _articleRepository;
        private readonly IArticleRepository _articleRepository;
        private readonly ArticleManager _articleManage;

        private IEventBus EventBus { get; set; }
        public ArticleAppService(IArticleRepository articleRepository, ArticleManager articleManage
)
        {
            _articleRepository = articleRepository;
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
            var expressionList = new List<Expression<Func<Article, bool>>>();
            if (!string.IsNullOrWhiteSpace(param.search))
            {
                expressionList.Add(m => m.Title == param.search);
            }
            var predicate = Amayer.Express.Express.BulidExpression(expressionList);
            var query = _articleRepositoryAsNoTrack.Where(predicate);

            var count = await query.CountAsync();

            try
            {
                var list = query
               .OrderByDescending(m => m.Id)
               .Skip(param.offset)
               .Take(param.limit)
               .ToList();
                var listDtos = list.MapTo<List<ArticleListDto>>();
                return new BsTableResponseModel<ArticleListDto>()
                {
                    rows = listDtos,
                    total = count
                };
            }

            //var tgs = _articleRepository.GetAll().AsNoTracking().OrderBy(m => m.Id).Skip(param.offset).Take(10);
            //var stgs = _articleRepository.GetAll().AsNoTracking().OrderBy(m => m.Id).Skip(param.offset).Take(10).ToList();
            //var stssgs = await _articleRepository.GetAll().AsNoTracking().OrderBy(m => m.Id).Skip(param.offset).Take(10).ToListAsync();


            catch (Exception e)
            {
                var es = e.Message;
            }
            return new BsTableResponseModel<ArticleListDto>()
            {
               
            };

        }

        /// <summary>
        /// 通过Id获取文章信息进行编辑或修改 
        /// </summary>
        public async Task<GetArticleForEditOutput> GetArticleForEditAsync(NullableIdDto<long> input)
        {
            var output = new GetArticleForEditOutput();

            ArticleEditDto articleEditDto;

            if (input.Id.HasValue)
            {
                var entity = await _articleRepository.GetAsync(input.Id.Value);
                articleEditDto = entity.MapTo<ArticleEditDto>();
            }
            else
            {
                articleEditDto = new ArticleEditDto();
            }

            output.Article = articleEditDto;
            return output;
        }


        /// <summary>
        /// 通过指定id获取文章ListDto信息
        /// </summary>
        public async Task<ArticleListDto> GetArticleByIdAsync(EntityDto<int> input)
        {
            var entity = await _articleRepository.GetAsync(input.Id);

            return entity.MapTo<ArticleListDto>();
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

        public void TestEvent()
        {
            EventBus.Trigger(new ArticleEventData { Article = new Article { } });
        }


    }
}
