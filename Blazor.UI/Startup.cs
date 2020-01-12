using Blazor.UI.Client.Services.Contracts;
using Blazor.UI.Client.Services.Implementations;
using Microsoft.AspNetCore.Blazor.Http;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.UI.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthorizationCore();
            services.AddScoped<IdentityAuthenticationStateProvider>();
            services.AddScoped<AuthenticationStateProvider>(s => s.GetRequiredService<IdentityAuthenticationStateProvider>());
            services.AddScoped<IAuthorizeApi, AuthorizeApi>();

            //services.AddMatToaster(config =>
            //{
            //    config.Position = MatToastPosition.BottomRight;
            //    config.PreventDuplicates = true;
            //    config.NewestOnTop = true;
            //    config.ShowCloseButton = true;
            //    config.MaximumOpacity = 95;
            //    config.VisibleStateDuration = 3000;
            //});
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            WebAssemblyHttpMessageHandlerOptions.DefaultCredentials = FetchCredentialsOption.Include;
            app.AddComponent<App>("app");
            //app.UseLoadingBar();
        }
    }
}
