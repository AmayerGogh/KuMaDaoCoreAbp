
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Dto
{
    public class PagedSortedAndFilteredInputDto : PagedAndSortedInputDto
    {
        public string Filter { get; set; }
    }
}