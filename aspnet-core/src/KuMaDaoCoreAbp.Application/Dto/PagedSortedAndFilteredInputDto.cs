
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Dto
{
    /// <summary></summary>
    public class PagedSortedAndFilteredInputDto : PagedAndSortedInputDto
    {
        /// <summary></summary>
        public string Filter { get; set; }
    }
}