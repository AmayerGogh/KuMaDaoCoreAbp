using AutoMapper;

namespace KuMaDaoCoreAbp.Categories.Mapper
{
    using KuMaDaoCoreAbp.Categories;
    using KuMaDaoCoreAbp.Categories.Dto;

    /// <summary>
    /// 配置Category的AutoMapper
    /// </summary>
    internal static class CustomerCategoryMapper 
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
           // configuration.CreateMap <Category, CategoryDto>();
            configuration.CreateMap<Category, CategoryListDto>();
            configuration.CreateMap<CategoryEditDto, Category>();
            configuration.CreateMap<Category, CategoryEditDto>();
            // configuration.CreateMap<CreateCategoryInput, Category>();
            //        configuration.CreateMap<Category, GetCategoryForEditOutput>();
            //  CreateMap<UserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
            configuration.CreateMap<Category, CategorySelectListItem>().ConvertUsing<CategorySelectListItemTypeConverter>();
        }


    }
    class CategorySelectListItemTypeConverter : ITypeConverter<Category, CategorySelectListItem>
    {
        public CategorySelectListItem Convert(Category source, CategorySelectListItem destination, ResolutionContext context)
        {
            return new CategorySelectListItem()
            {
                Text = source.Name,
                Value = source.Id.ToString()
            };
        }
    }
}