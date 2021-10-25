using kace_api_netcore.Auth;
using kace_api_netcore.Auth.Interfaces;
using kace_api_netcore.Data.Mappings;
using kace_api_netcore.Extensions;
using kace_api_netcore.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace kace_api_netcore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private const string ProdCors = "prodCorsPolicy";
        private const string DevCors = "devCorsPolicy";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureCors(ProdCors, DevCors);

            services.AddControllers();
            services.ConfigureSwagger();

            services.ConfigureDbContext(Configuration);

            services.ConfigureK1000();
            services.ConfigureK2000();

            services.AddAutoMapper(typeof(K1000MappingProfile));

            services.AddAuthentication(IISDefaults.AuthenticationScheme);

            services.AddTransient<IAuthenticationService, AuthenticationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseCors(DevCors);
            }
            else
            {
                app.UseCors(ProdCors);
            }

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseMiddleware<SwaggerAuthorizationMiddleware>();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "Kace API v1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers().RequireAuthorization();
            });
        }
    }
}