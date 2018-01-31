using KuMaDaoCoreAbp.Articles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KuMaDaoCoreAbp.Web.Areas.Admin.Models.Article
{
    public class EditArticleModal
    {
      public ArticleEditDto GetArticleForEditOutput { get; set; }
    }


    public class EditArticleDetailModal
    {
       public ArticleDetailEditDto ArticleDetailDto { get; set; }
    }
}
