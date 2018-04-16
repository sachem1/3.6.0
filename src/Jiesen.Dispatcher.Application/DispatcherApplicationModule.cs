using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Jiesen.Dispatcher.Authorization;

namespace Jiesen.Dispatcher
{
    [DependsOn(
        typeof(DispatcherCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DispatcherApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DispatcherAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DispatcherApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
