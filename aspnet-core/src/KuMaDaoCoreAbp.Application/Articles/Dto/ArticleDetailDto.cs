using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KuMaDaoCoreAbp.Articles.Dto
{
    /// <summary>
    /// 
    /// </summary>
    [AutoMapFrom(typeof(ArticleDetail))]
    public  class ArticleDetailEditDto
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        
        public long ArticleId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("内容")]
        [MaxLength(20000,ErrorMessage ="{0}超出长度")]
        public string Body { get; set; }

    }
}
