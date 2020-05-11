using Repositories.Contexts;
using HolidayHomesOwnersWebApi.Handlers;
using Repositories.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace HolidayHomesOwnersWebApi
{
    public static class StartupServicesExtensionsForBasicAuthorization
    {
        public static void AddCustomBasicAuthorization(this IServiceCollection services, string connectionString)
        {
            services.ConfigureBasicAuthentication();
            services.ConfigureDbContext<UsersContext>(connectionString);
            services.AddScoped<IUsersRepository, UsersRepository>();
        }

        private static void ConfigureBasicAuthentication(this IServiceCollection services)
        {
            string authenticationScheme = "BasicAuthentication";
            services.AddAuthentication(authenticationScheme)
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>(authenticationScheme, null);
        }
    }
}
