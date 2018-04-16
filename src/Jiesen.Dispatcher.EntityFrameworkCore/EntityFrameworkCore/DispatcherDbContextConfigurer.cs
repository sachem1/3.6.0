using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Jiesen.Dispatcher.EntityFrameworkCore
{
    public static class DispatcherDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DispatcherDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DispatcherDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
