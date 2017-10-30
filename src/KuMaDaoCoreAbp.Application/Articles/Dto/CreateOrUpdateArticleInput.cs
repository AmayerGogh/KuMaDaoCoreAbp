
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace KuMaDaoCoreAbp.Article.Dto
{
    /// <summary>
    /// 文章新增和编辑时用Dto
    /// </summary>
    
    public class CreateOrUpdateArticleInput  
    {
    /// <summary>
    /// 文章编辑Dto
    /// </summary>
		public ArticleEditDto  ArticleEditDto {get;set;}
 
    }
}
