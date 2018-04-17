using System;
using Abp.Application.Services.Dto;
using KuMaDaoCoreAbp.Categories;

namespace KuMaDaoCoreAbp.Categories.Dto
{
    public class CategoryListDto : EntityDto<long>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        public string Name { get; set; }
        public long ParentId { get; set; }
        public int Status { get; set; }
        public int Sort { get; set; }
        public string Mark { get; set; }
        public string Icon { get; set; }
        public int Type { get; set; }
    }
}