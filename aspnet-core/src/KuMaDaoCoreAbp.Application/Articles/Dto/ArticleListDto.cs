
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Application.Services.Dto;
using System.Collections.Generic;

namespace KuMaDaoCoreAbp.Articles.Dto
{
    /// <summary>
    /// 文章列表Dto
    /// </summary>
   
    public class ArticleListDto : EntityDto<long>
    {
        /// <summary></summary>
        public string Title { get; set; }
        /// <summary></summary>
        public long CategoryId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreationTime { get; set; }
        /// <summary></summary>
        public string CategoryName { get; set; }
        /// <summary></summary>
        public List<ArticleListDto_Detail> ArticleDetail { get; set; }
     }
    /// <summary></summary>
    public class ArticleListDto_Detail
    {
        /// <summary></summary>
        public virtual long Id { get; set; }
        /// <summary></summary>
        public virtual bool IsDefault { get; set; }
        /// <summary></summary>
        public virtual long ArticleId { get; set; }


    }


}
