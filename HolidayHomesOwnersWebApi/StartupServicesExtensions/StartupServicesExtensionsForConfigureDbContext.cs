using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HolidayHomesOwnersWebApi
{
    public static class StartupServicesExtensionsForConfigureDbContext
    {
        public static void ConfigureDbContext<T>(this IServiceCollection services, string connectionString)
            where T: DbContext
        {
            services.AddDbContext<T>(o =>
            {
                o.UseSqlServer(connectionString);
            });
        }
    }
}
