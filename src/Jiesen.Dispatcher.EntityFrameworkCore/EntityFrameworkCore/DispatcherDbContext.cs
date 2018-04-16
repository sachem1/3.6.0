using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Jiesen.Dispatcher.Authorization.Roles;
using Jiesen.Dispatcher.Authorization.Users;
using Jiesen.Dispatcher.MultiTenancy;

namespace Jiesen.Dispatcher.EntityFrameworkCore
{
    public class DispatcherDbContext : AbpZeroDbContext<Tenant, Role, User, DispatcherDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DispatcherDbContext(DbContextOptions<DispatcherDbContext> options)
            : base(options)
        {
        }
    }
}
