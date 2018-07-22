using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KuMaDaoCoreAbp.Categories.Dto;
using KuMaDaoCoreAbp.Categories;

namespace KuMaDaoCoreAbp.Categories
{
    /// <summary>
    /// Category应用层服务的接口方法
    /// </summary>
    public interface ICategoryAppService : IApplicationService
    {
        /// <summary>
        /// 获取Category的分页列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<CategoryListDto>> GetPagedCategorys(GetCategorysInput input);

        /// <summary>
        /// 通过指定id获取CategoryListDto信息
        /// </summary>
        Task<CategoryListDto> GetCategoryByIdAsync(EntityDto<long> input);

       
        /// <summary>
        /// MPA版本才会用到的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetCategoryForEditOutput> GetCategoryForEdit(NullableIdDto<long> input);

       
        /// <summary>
        /// 添加或者修改Category的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdateCategory(CreateOrUpdateCategoryInput input);

        /// <summary>
        /// 删除Category信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeleteCategory(EntityDto<long> input);

        /// <summary>
        /// 批量删除Category
        /// </summary>
        Task BatchDeleteCategorysAsync(List<long> input);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<List<CategorySelectListItem>> GetCategoryByType2KVAsync(EnumCategoryType input);
        Task<CategoryRecursion> GetCategoryRecursionAsync(int type);
    }
}
