using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace KuMaDaoCoreAbp.Localization
{
    public static class KuMaDaoCoreAbpLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(KuMaDaoCoreAbpConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(KuMaDaoCoreAbpLocalizationConfigurer).GetAssembly(),
                        "KuMaDaoCoreAbp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
