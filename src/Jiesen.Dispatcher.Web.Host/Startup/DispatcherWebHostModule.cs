using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Jiesen.Dispatcher.Configuration;

namespace Jiesen.Dispatcher.Web.Host.Startup
{
    [DependsOn(
       typeof(DispatcherWebCoreModule))]
    public class DispatcherWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DispatcherWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DispatcherWebHostModule).GetAssembly());
        }
    }
}
