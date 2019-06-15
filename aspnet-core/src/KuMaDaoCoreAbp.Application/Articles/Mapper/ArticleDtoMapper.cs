using AutoMapper;
using KuMaDaoCoreAbp.Articles.Dto;

namespace KuMaDaoCoreAbp.Articles.Mapper
{
    /// <summary>
    /// ArticleDto映射配置
    /// </summary>
    public class ArticleDtoMapper
    {

        private static volatile bool _mappedBefore;
        private static readonly object SyncObj = new object();



        /// <summary>
        /// 初始化映射
        /// </summary>
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {

            lock (SyncObj)
            {
                if (_mappedBefore)
                {
                    return;
                }

                CreateMappingsInternal(configuration);

                _mappedBefore = true;
            }

            configuration.CreateMap<Article, ArticleEditDto>();
            configuration.CreateMap<Article, ArticleListDto>();

            configuration.CreateMap<ArticleEditDto, Article>();
            configuration.CreateMap<Article, ArticleListDto>()
                //.BeforeMap((a, b) => { a.CategoryId =a.CategoryId+1})   
                //.AfterMap((src, dest) => dest.Name = HttpContext.Current.Identity.Name);
                //.ForMember(dest => dest.Age, opt => opt.Condition(src => src.Age > 0 && src.Age < 149)); 条件映射
                .ForMember(artd => artd.CategoryName, o => o.Ignore());
        }





        /// <summary>
        ///    Configuration.Modules.AbpAutoMapper().Configurators.Add(ArticleDtoMapper.CreateMappings);
        ///注入位置    see cref = AbpProjectTemplateApplicationModule 
        /// <param name="configuration"></param>
        /// </summary>       
        private static void CreateMappingsInternal(IMapperConfigurationExpression configuration)
        {






        }


    }
}