                            
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Application.Services.Dto;

namespace KuMaDaoCoreAbp.Articles.Dto
{
	/// <summary>
    /// 文章列表Dto
    /// </summary>
    [AutoMapFrom(typeof(Articles.Article))]
    public class ArticleListDto : EntityDto<long>
    {
        public      string Title { get; set; }
        public      int CategoryId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public      DateTime CreationTime { get; set; }
    }
}
