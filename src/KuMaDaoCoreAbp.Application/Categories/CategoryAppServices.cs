using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;

using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;

using KuMaDaoCoreAbp.Categories.Dto;
using KuMaDaoCoreAbp.Categories.DomainServices;
using KuMaDaoCoreAbp.Categories;

namespace KuMaDaoCoreAbp.Categories
{
    /// <summary>
    /// Category应用层服务的接口实现方法
    /// </summary>

    public class CategoryAppService : KuMaDaoCoreAbpAppServiceBase, ICategoryAppService
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        private readonly IRepository<Category, long> _categoryRepository;
        private readonly ICategoryManager _categoryManager;

        /// <summary>
        /// 构造函数
        /// </summary>
        public CategoryAppService(IRepository<Category, long> categoryRepository
      , ICategoryManager categoryManager
        )
        {
            _categoryRepository = categoryRepository;
            _categoryManager = categoryManager;
        }

        /// <summary>
        /// 获取Category的分页列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<CategoryListDto>> GetPagedCategorys(GetCategorysInput input)
        {

            var query = _categoryRepository.GetAll();
            //TODO:根据传入的参数添加过滤条件
            var categoryCount = await query.CountAsync();

            var categorys = await query
                .OrderBy(input.Sorting)
                .PageBy(input)
                .ToListAsync();

            var categoryListDtos = categorys.MapTo<List<CategoryListDto>>();

            return new PagedResultDto<CategoryListDto>(
                categoryCount,
                categoryListDtos
                );

        }

        /// <summary>
        /// 通过指定id获取CategoryListDto信息
        /// </summary>
        public async Task<CategoryListDto> GetCategoryByIdAsync(EntityDto<long> input)
        {
            var entity = await _categoryRepository.GetAsync(input.Id);

            return entity.MapTo<CategoryListDto>();
        }

        /// <summary>
        /// 获取 下拉框形式
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<object> GetCategoryByType2KVAsync(int input)
        {
            return _categoryRepository.GetAllListAsync(m => m.Type == input).MapTo<CategorySelectListItem>();
        }
        /// <summary>
        /// MPA版本才会用到的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetCategoryForEditOutput> GetCategoryForEdit(NullableIdDto<long> input)
        {
            var output = new GetCategoryForEditOutput();
            CategoryEditDto categoryEditDto;

            if (input.Id.HasValue)
            {
                var entity = await _categoryRepository.GetAsync(input.Id.Value);

                categoryEditDto = entity.MapTo<CategoryEditDto>();

                //categoryEditDto = ObjectMapper.Map<List <categoryEditDto>>(entity);
            }
            else
            {
                categoryEditDto = new CategoryEditDto();
            }

            output.Category = categoryEditDto;
            return output;

        }

        /// <summary>
        /// 添加或者修改Category的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task CreateOrUpdateCategory(CreateOrUpdateCategoryInput input)
        {

            if (input.Category.Id.HasValue)
            {
                await UpdateCategoryAsync(input.Category);
            }
            else
            {
                await CreateCategoryAsync(input.Category);
            }
        }

        /// <summary>
        /// 新增Category
        /// </summary>

        protected virtual async Task<CategoryEditDto> CreateCategoryAsync(CategoryEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增
            var entity = ObjectMapper.Map<Category>(input);

            entity = await _categoryRepository.InsertAsync(entity);
            return entity.MapTo<CategoryEditDto>();
        }

        /// <summary>
        /// 编辑Category
        /// </summary>

        protected virtual async Task UpdateCategoryAsync(CategoryEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新
            var entity = await _categoryRepository.GetAsync(input.Id.Value);
            input.MapTo(entity);

            // ObjectMapper.Map(input, entity);
            await _categoryRepository.UpdateAsync(entity);
        }

        /// <summary>
        /// 删除Category信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public async Task DeleteCategory(EntityDto<long> input)
        {

            //TODO:删除前的逻辑判断，是否允许删除
            await _categoryRepository.DeleteAsync(input.Id);
        }

        /// <summary>
        /// 批量删除Category的方法
        /// </summary>

        public async Task BatchDeleteCategorysAsync(List<long> input)
        {
            //TODO:批量删除前的逻辑判断，是否允许删除
            await _categoryRepository.DeleteAsync(s => input.Contains(s.Id));
        }

        public Task<CategoryRecursion> GetCategoryRecursionAsync(int type)
        {
            throw new System.NotImplementedException();
        }
    }
}

