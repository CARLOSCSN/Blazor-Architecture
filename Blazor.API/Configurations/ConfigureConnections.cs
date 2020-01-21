using System;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DataEFCore;

namespace API.Configurations
{
    public static class ConfigureConnections
    {
        public static IServiceCollection AddConnectionProvider(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connection = String.Empty;
            
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                connection = configuration.GetConnectionString("BlazorDbWindows") ??
                                 "Server=.;Database=Blazor;Trusted_Connection=True;Application Name=BlazorASPNETCoreAPINTier";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                connection = configuration.GetConnectionString("BlazorDbDocker") ??
                                 "Server=localhost,1433;Database=Blazor;User=sa;Password=Pa55w0rd;Trusted_Connection=False;Application Name=BlazorASPNETCoreAPINTier";
            }
            
            services.AddDbContextPool<BlazorContext>(options => options.UseSqlServer(connection));

            return services;
        }
    }
}