using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KuMaDaoCoreAbp.Articles.Dto;

using KuMaDaoCoreAbp.Web;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KuMaDaoCoreAbp.Articles
{
    /// <summary>
    /// 
    /// </summary>
    public interface IArticleAppService : IApplicationService
    {
        /// <summary>
        /// 根据查询条件获取文章分页列表
        /// </summary>        
        Task<BsTableResponseModel<ArticleListDto>> PagedArticlesAsync(BsTableRequestModel param);
        /// <summary>
        /// 通过Id获取文章信息进行编辑或修改 
        /// </summary>
        Task<ArticleEditDto> GetArticleForEditAsync(NullableIdDto<long> input);

        /// <summary>
        /// 通过指定id获取文章ListDto信息
        /// </summary>
        Task<ArticleListDto> GetArticleByIdAsync(EntityDto<long> input);
        /// <summary>
        /// 新
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ArticleForEditDto> GetArticleForEditAsync2(NullableIdDto<long> input);
        // object PostTest(object input);




        /// <summary>
        /// 获取文章内容
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ArticleDetailEditDto> GetArticleDetailByArticleIdAsync(EntityDto<long> input);
        /// <summary>
        /// 编辑文章内容
        /// </summary>
        Task CreateOrUpdateArticleDetailAsync(ArticleDetailEditDto input);
    }
}
