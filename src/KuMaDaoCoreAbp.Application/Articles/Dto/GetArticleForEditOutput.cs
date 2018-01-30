
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace KuMaDaoCoreAbp.Article.Dto
{
	/// <summary>
    /// 用于添加或编辑 文章时使用的DTO
    /// </summary>
  
    public class GetArticleForEditOutput 
    {
 

	    /// <summary>
        /// Article编辑状态的DTO
        /// </summary>
        public ArticleEditDto Article{get;set;}


    }
}
