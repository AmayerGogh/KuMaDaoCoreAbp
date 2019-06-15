using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KuMaDaoCoreAbp.Dto
{
    /// <summary></summary>
    public class PagedAndFilteredInputDto : IPagedResultRequest
    {
        /// <summary></summary>
        [Range(1, AppConsts.MaxPageSize)]
        public int MaxResultCount { get; set; }
        /// <summary></summary>

        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }
        /// <summary></summary>

        public string Filter { get; set; }
        /// <summary></summary>

        public PagedAndFilteredInputDto()
        {
            MaxResultCount = AppConsts.DefaultPageSize;
        }
    }
}