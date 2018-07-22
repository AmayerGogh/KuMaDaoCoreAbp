using Abp.Application.Services.Dto;
using KuMaDaoCoreAbp;
using KuMaDaoCoreAbp.Dto;

namespace KuMaDaoCoreAbp.Dto
{
    public class PagedAndSortedInputDto : PagedInputDto, ISortedResultRequest
    {
        public string Sorting { get; set; }

        public PagedAndSortedInputDto()
        {
            MaxResultCount = AppConsts.DefaultPageSize;
        }
    }
}