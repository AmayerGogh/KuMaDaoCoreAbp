using KuMaDaoCoreAbp.Articles.Dto;
using KuMaDaoCoreAbp.Categories.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KuMaDaoCoreAbp.Web.Areas.Admin.Models.Article
{
    public class ArticleIndexViewModel
    {
        public List<CategorySelectListItem> ArticleTypeList { get; set; }

        
    }
}
