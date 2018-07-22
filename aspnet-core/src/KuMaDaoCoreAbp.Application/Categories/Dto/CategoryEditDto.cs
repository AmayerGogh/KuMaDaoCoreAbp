using System.ComponentModel.DataAnnotations;

using KuMaDaoCoreAbp.Categories;

namespace KuMaDaoCoreAbp.Categories.Dto
{
    public class CategoryEditDto
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        public long? Id { get; set; }
        public string Name { get; set; }
        public long ParentId { get; set; }
        public int Status { get; set; }
        public int Sort { get; set; }
        public string Mark { get; set; }
        public string Icon { get; set; }
        public int Type { get; set; }
    }
}