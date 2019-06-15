using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using KuMaDaoCoreAbp.Categories;

namespace KuMaDaoCoreAbp.Categories.Dto
{
    /// <summary></summary>
    public class CreateOrUpdateCategoryInput
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        /// <summary></summary>
        [Required]
        public CategoryEditDto Category { get; set; }

    }
}