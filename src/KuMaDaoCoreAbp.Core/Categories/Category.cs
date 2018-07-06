using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Categories
{
    public  class Category:Entity<long>
    {
        public string Name { get; set; }
        public long ParentId { get; set; }
        public int Status { get; set; }
        public int Sort { get; set; }
        public string Mark { get; set; }
        public string Icon { get; set; }

        public int Type { get; set; }
    }

    public enum CategoryType
    {
        文章=1
    }
}
