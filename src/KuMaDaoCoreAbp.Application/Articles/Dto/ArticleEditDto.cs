                          
  
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace KuMaDaoCoreAbp.Article.Dto
{
    /// <summary>
    /// 文章编辑用Dto
    /// </summary>
    [AutoMap(typeof(Articles.Article))]
    public class ArticleEditDto 
    {

	    /// <summary>
        ///   主键Id
        /// </summary>
        [DisplayName("主键Id")]
	    public long? Id{get;set;}

        [Required]
        [MaxLength(20)]
        public   string  Title { get; set; }

        public   string  Body { get; set; }

        public   int  CategoryId { get; set; }

    }
}
