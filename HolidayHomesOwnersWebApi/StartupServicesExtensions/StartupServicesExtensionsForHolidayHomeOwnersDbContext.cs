using Repositories.Contexts;
using Repositories.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HolidayHomesOwnersWebApi
{
    public static class ForHolidayHomeOwnersDbContext
    {
        public static void AddOwnersDbContext(this IServiceCollection services, string connectionString)
        {
            services.ConfigureDbContext<HolidayHomesOwnersContext>(connectionString);
            services.AddScoped<IHolidayHomesOwnersRepository, HolidayHomesOwnersRepository>();
        }
    }
}
