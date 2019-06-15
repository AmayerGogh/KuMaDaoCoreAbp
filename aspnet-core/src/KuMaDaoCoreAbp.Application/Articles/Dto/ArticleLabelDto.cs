using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Articles.Dto
{
    /// <summary></summary>
    [AutoMapFrom(typeof(Articles.ArticleDetail))]
    class ArticleLabelDto
    {
        /// <summary></summary>
        public long Id { get; set; }
        /// <summary></summary>
        public string Name { get; set; }
    }
}
