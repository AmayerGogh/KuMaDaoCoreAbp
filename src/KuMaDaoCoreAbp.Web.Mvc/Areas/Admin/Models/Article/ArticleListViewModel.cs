using KuMaDaoCoreAbp.Article.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KuMaDaoCoreAbp.Web.Areas.Admin.Models.Article
{
    public class ArticleListViewModel
    {
        public IReadOnlyList<ArticleListDto> Articles { get; set; }

        public ArticleEditDto ArticleEditModal { get; set; }
    }
}
