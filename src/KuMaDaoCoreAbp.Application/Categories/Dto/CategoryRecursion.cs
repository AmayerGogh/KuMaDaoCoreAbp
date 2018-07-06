using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Categories.Dto
{
   public  class CategoryRecursion:Category
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long ParentId { get; set; }
        public int Status { get; set; }
        public int Sort { get; set; }
        public string Mark { get; set; }
        public string Icon { get; set; }

        public int Type { get; set; }
        public List<Category> Children { get; set; }
    }
}
