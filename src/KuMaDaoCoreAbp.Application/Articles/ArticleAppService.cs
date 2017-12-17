using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using KuMaDaoCoreAbp.Article.Dto;
using KuMaDaoCoreAbp.Articles.Authorization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuMaDaoCoreAbp.Articles
{
    [AbpAuthorize(ArticleAppPermissions.Article)]
    public   class ArticleAppService: KuMaDaoCoreAbpAppServiceBase, IArticleAppService
    {
        private readonly IRepository<Article, long> _articleRepository;

        private readonly ArticleManager _articleManage;

        public ArticleAppService(IRepository<Article, long> articleRepository, ArticleManager articleManage
)
        {
            _articleRepository = articleRepository;
            _articleManage = articleManage;
        }

        private IQueryable<Article> _articleRepositoryAsNoTrack => _articleRepository.GetAll().AsNoTracking();




        #region 文章管理

        /// <summary>
        /// 根据查询条件获取文章分页列表
        /// </summary>
        public async Task<PagedResultDto<ArticleListDto>> GetPagedArticlesAsync(GetArticleInput input)
        {

            var query = _articleRepositoryAsNoTrack;
            //TODO:根据传入的参数添加过滤条件

            var articleCount = await query.CountAsync();

            var articles = await query
            //.OrderBy(input.Sorting)
            //.PageBy(input)
            .ToListAsync();

            var articleListDtos = articles.MapTo<List<ArticleListDto>>();
            return new PagedResultDto<ArticleListDto>(
            articleCount,
            articleListDtos
            );
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
        [AbpAuthorize(ArticleAppPermissions.Article_CreateArticle)]
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
        [AbpAuthorize(ArticleAppPermissions.Article_EditArticle)]
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
        [AbpAuthorize(ArticleAppPermissions.Article_DeleteArticle)]
        public async Task DeleteArticleAsync(EntityDto<int> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _articleRepository.DeleteAsync(input.Id);
        }

        /// <summary>
        /// 批量删除文章
        /// </summary>
        [AbpAuthorize(ArticleAppPermissions.Article_DeleteArticle)]
        public async Task BatchDeleteArticleAsync(List<long> input)
        {
            //TODO:批量删除前的逻辑判断，是否允许删除
            await _articleRepository.DeleteAsync(s => input.Contains(s.Id));
        }

        #endregion

    }
}
