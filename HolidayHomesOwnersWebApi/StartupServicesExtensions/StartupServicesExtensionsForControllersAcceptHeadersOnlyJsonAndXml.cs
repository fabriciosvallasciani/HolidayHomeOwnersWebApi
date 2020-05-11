using Microsoft.Extensions.DependencyInjection;

namespace HolidayHomesOwnersWebApi
{
    public static class StartupServicesExtensionsForControllersAcceptHeadersOnlyJsonAndXml
    {
        public static void AddControllersAcceptHeadersOnlyJsonAndXml(this IServiceCollection services)
        {
            services.AddControllers(setupAction =>
            {
                setupAction.ReturnHttpNotAcceptable = true;
            }).AddXmlDataContractSerializerFormatters(); //NOTE: responses should be in json but xml could also be added
        }
    }
}
