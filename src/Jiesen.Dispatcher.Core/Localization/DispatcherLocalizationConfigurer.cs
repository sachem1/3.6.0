using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Jiesen.Dispatcher.Localization
{
    public static class DispatcherLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DispatcherConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DispatcherLocalizationConfigurer).GetAssembly(),
                        "Jiesen.Dispatcher.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
