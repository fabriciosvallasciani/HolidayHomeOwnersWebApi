using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace HolidayHomesOwnersWebApi
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        private string _connectionString
        {
            get { return _configuration["ConnectionStrings:HolidayHomesOwnersDbConnectionString"]; }
        }

        private string _frontendUrl
        {
            get { return _configuration["ConnectionStrings:FrontEndUrl"]; }
        }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration ??
                throw new ArgumentNullException(nameof(configuration));
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCustomCors(_frontendUrl);
            services.AddCustomBasicAuthorization(_connectionString);
            services.AddHolidayHomeOwnersDbContext(_connectionString);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllersAcceptHeadersOnlyJsonAndXml();
        }              

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("CorsPolicy");


            ManageAppGlobalExceptionsBasedOnEnvironment(app, env);

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }

        private void ManageAppGlobalExceptionsBasedOnEnvironment(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseExceptionHandler("/error-local-development");
            }
            else
            {
                app.UseExceptionHandler("/error");
            }
        }
    }
}
