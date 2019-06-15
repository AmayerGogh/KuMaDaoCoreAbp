using System;
using Abp.Application.Services.Dto;
using KuMaDaoCoreAbp.Categories;

namespace KuMaDaoCoreAbp.Categories.Dto
{
    /// <summary></summary>
    public class CategoryListDto : EntityDto<long>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        /// <summary></summary>
        public string Name { get; set; }
        /// <summary></summary>
        public long ParentId { get; set; }
        /// <summary></summary>
        public int Status { get; set; }
        /// <summary></summary>
        public int Sort { get; set; }
        /// <summary></summary>
        public string Mark { get; set; }
        /// <summary></summary>
        public string Icon { get; set; }
        /// <summary></summary>
        public int Type { get; set; }
    }
}