using kace_api_netcore.Data.K1000.Interfaces;
using kace_api_netcore.Data.K1000.Services;
using kace_api_netcore.Data.K2000.Interfaces;
using kace_api_netcore.Data.K2000.Services;
using kace_api_netcore.Entities.K1000;
using kace_api_netcore.Entities.K2000;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace kace_api_netcore.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services, string prodPolicyName, string devPolicyName)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(devPolicyName,
                    builder => builder
                        .WithOrigins("http://localhost:8080")
                        .AllowAnyHeader()
                        .AllowCredentials()
                        .AllowAnyMethod());

                options.AddPolicy(prodPolicyName,
                    builder => builder
                        .WithOrigins("http://servername")
                        .AllowAnyHeader()
                        .AllowCredentials()
                        .AllowAnyMethod());
            });
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Kace API", Version = "v1" });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<ORG1Context>(options =>
                options
                    .UseMySql(Environment.GetEnvironmentVariable("K1000ConnectionString") ?? throw new InvalidOperationException("K1000ConnectionString Environment Variable missing"),
                        new MariaDbServerVersion(new Version(2, 2, 3))));

            services.AddDbContextPool<KBDBContext>(options =>
                options
                    .UseMySql(Environment.GetEnvironmentVariable("K2000ConnectionString") ?? throw new InvalidOperationException("K2000ConnectionString Environment Variable missing"),
                        new MariaDbServerVersion(new Version(2, 2, 6))));
        }

        public static void ConfigureK1000(this IServiceCollection services)
        {
            services.AddTransient<IAssetsService, AssetsService>();
            services.AddTransient<IHdTicketsService, HdTicketsService>();
            services.AddTransient<IUsersService, UsersService>();
        }

        public static void ConfigureK2000(this IServiceCollection services)
        {
            services.AddTransient<IDeploymentsService, DeploymentsService>();
        }
    }
}
