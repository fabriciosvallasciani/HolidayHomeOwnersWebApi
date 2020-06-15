using Microsoft.Extensions.DependencyInjection;

namespace HolidayHomesOwnersWebApi
{
    public static class StartupServicesExtensionsForCors
    {
        public static void AddCustomCors(this IServiceCollection services, string frontendUrl)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(
                  "CorsPolicy",
                  builder => builder.WithOrigins(frontendUrl)
                  .AllowAnyMethod()
                  .AllowAnyHeader());
            });
        }
    }
}
