using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Articles.Dto
{
    [AutoMapFrom(typeof(Articles.ArticleDetail))]
    class ArticleLabelDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
