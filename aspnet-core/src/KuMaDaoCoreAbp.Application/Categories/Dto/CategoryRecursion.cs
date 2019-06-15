using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Categories.Dto
{
    /// <summary>
    /// category 树的形式
    /// </summary>
    public class CategoryRecursion : Category
    {
        /// <summary></summary>
        public Category Category { get; set; }
        /// <summary></summary>
        public List<Category> Children { get; set; }
    }
}
