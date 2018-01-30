using KuMaDaoCoreAbp.Articles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KuMaDaoCoreAbp.Web.Areas.Admin.Models.Article
{
    public class EditArticleModal
    {
      public   GetArticleForEditOutput GetArticleForEditOutput { get; set; }
    }


    public class EditArticleDetailModal
    {
       public ArticleDetailDto ArticleDetailDto { get; set; }
    }
}
