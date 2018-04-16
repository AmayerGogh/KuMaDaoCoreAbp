
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
        public string Title { get; set; }
        public long CategoryId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreationTime { get; set; }

        public string CategoryName { get; set; }
  
        public  List<ArticleListDto_Detail> ArticleDetail { get; set; }
     }

    public class ArticleListDto_Detail
    {
        public virtual long Id { get; set; }
        public virtual bool IsDefault { get; set; }
    }


}
