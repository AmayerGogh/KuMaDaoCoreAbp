﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Articles
{
    public class ArticleLabel:Entity<long>
    {
        public long ArticleId { get; set; }
        public string Name { get; set; }
    }
}
