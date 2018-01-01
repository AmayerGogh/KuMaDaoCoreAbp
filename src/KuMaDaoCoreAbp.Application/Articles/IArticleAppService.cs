using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KuMaDaoCoreAbp.Article.Dto;
using KuMaDaoCoreAbp.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KuMaDaoCoreAbp.Articles
{
    public interface IArticleAppService:IApplicationService
    {
        /// <summary>
        /// 根据查询条件获取文章分页列表
        /// </summary>        
        Task<PagedResultDto<ArticleListDto>> GetPagedArticlesAsync(BsTableRequestModel param);
        /// <summary>
        /// 通过Id获取文章信息进行编辑或修改 
        /// </summary>
        Task<GetArticleForEditOutput> GetArticleForEditAsync(NullableIdDto<long> input);

        /// <summary>
        /// 通过指定id获取文章ListDto信息
        /// </summary>
        Task<ArticleListDto> GetArticleByIdAsync(EntityDto<int> input);


       // object PostTest(object input);
    }
}
