using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Category
{
    public  class Category:Entity<long>
    {
        public string Name { get; set; }
        public long ParentId { get; set; }
        public int Status { get; set; }
        public int Sort { get; set; }
        public string Mark { get; set; }
        public string Icon { get; set; }
    }
}
