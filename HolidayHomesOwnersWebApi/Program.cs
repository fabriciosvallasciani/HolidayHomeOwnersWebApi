using Repositories.Contexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HolidayHomesOwnersWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            
            CreateDatabaseAndCreateAndSeedUsersTable(host);
            CreateAndSeedHolidayHomesOwnersContextTables(host);

            host.Run();
        }

        private static void CreateDatabaseAndCreateAndSeedUsersTable(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<UsersContext>();

                // setting for demo purposes only
                context.Database.EnsureDeleted();
                context.Database.Migrate();
            }
        }

        private static void CreateAndSeedHolidayHomesOwnersContextTables(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<HolidayHomesOwnersContext>();

                // setting for demo purposes only
                context.Database.Migrate();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
