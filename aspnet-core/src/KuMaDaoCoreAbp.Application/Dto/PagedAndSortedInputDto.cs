using Abp.Application.Services.Dto;
using KuMaDaoCoreAbp;
using KuMaDaoCoreAbp.Dto;

namespace KuMaDaoCoreAbp.Dto
{
    /// <summary></summary>
    public class PagedAndSortedInputDto : PagedInputDto, ISortedResultRequest
    {
        /// <summary></summary>
        public string Sorting { get; set; }
        /// <summary></summary>
        public PagedAndSortedInputDto()
        {
            MaxResultCount = AppConsts.DefaultPageSize;
        }
    }
}