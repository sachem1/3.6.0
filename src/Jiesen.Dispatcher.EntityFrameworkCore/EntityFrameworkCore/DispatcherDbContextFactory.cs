using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Jiesen.Dispatcher.Configuration;
using Jiesen.Dispatcher.Web;

namespace Jiesen.Dispatcher.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DispatcherDbContextFactory : IDesignTimeDbContextFactory<DispatcherDbContext>
    {
        public DispatcherDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DispatcherDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DispatcherDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DispatcherConsts.ConnectionStringName));

            return new DispatcherDbContext(builder.Options);
        }
    }
}
