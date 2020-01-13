#pragma checksum "C:\Temp\Blazor-Architecture\Blazor.UI\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b30ddde24815053864a7524f51ae2a47326b1ba"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.UI.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#line 4 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization.Infrastructure;

#line default
#line hidden
#line 5 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 7 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 8 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 9 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 10 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 12 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Blazor.Infra.CrossCutting.SharedUI;

#line default
#line hidden
#line 13 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Blazor.UI.Client;

#line default
#line hidden
#line 14 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Blazor.UI.Client.Shared;

#line default
#line hidden
#line 15 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Blazor.UI.Client.Services.Contracts;

#line default
#line hidden
#line 16 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Blazor.UI.Client.Services.Implementations;

#line default
#line hidden
#line 18 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using MatBlazor;

#line default
#line hidden
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main" + " " + (
#line 5 "C:\Temp\Blazor-Architecture\Blazor.UI\Shared\MainLayout.razor"
                  NavMenuCssClass

#line default
#line hidden
            ));
            __builder.AddMarkupContent(2, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(3, "nav");
            __builder.AddAttribute(4, "class", "navbar navbar-default navbar-fixed-top");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container-fluid");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<div class=\"navbar-header\">\r\n                <a class=\"navbar-brand\" href=\"index.html\">\r\n                    Paralelas\r\n                    <br><span>Licitações</span>\r\n                </a>\r\n            </div>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "id", "navbar");
            __builder.AddAttribute(12, "class", "navbar-collapse collapse");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "left-nav-toggle");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 18 "C:\Temp\Blazor-Architecture\Blazor.UI\Shared\MainLayout.razor"
                                           ToggleNavMenu

#line default
#line hidden
            ));
            __builder.AddMarkupContent(20, "\r\n                        <i class=\"stroke-hamburgermenu\"></i>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<form class=\"navbar-form navbar-left\">\r\n                    <input type=\"text\" class=\"form-control\" placeholder=\"Search data for analysis\" style=\"width: 175px\">\r\n                </form>\r\n                ");
            __builder.OpenElement(24, "ul");
            __builder.AddAttribute(25, "class", "nav navbar-nav navbar-right");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "profil-link");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", "#");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 41 "C:\Temp\Blazor-Architecture\Blazor.UI\Shared\MainLayout.razor"
                                               LogoutClick

#line default
#line hidden
            ));
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.AddMarkupContent(34, "<span class=\"profile-address\">Sair</span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    \r\n\r\n    \r\n    ");
            __builder.OpenComponent<Blazor.UI.Client.Shared.NavMenu>(41);
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "content");
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.AddContent(46, 
#line 56 "C:\Temp\Blazor-Architecture\Blazor.UI\Shared\MainLayout.razor"
         Body

#line default
#line hidden
            );
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 60 "C:\Temp\Blazor-Architecture\Blazor.UI\Shared\MainLayout.razor"
           

    [CascadingParameter]
    Task<AuthenticationState> AuthenticationState { get; set; }
    bool collapseNavMenu = false;
    string NavMenuCssClass => collapseNavMenu ? "nav-toggle" : null;

    protected override async Task OnParametersSetAsync()
    {
        if (!(await AuthenticationState).User.Identity.IsAuthenticated)
        {
            navigationManager.NavigateTo("/login");
        }
    }

    async Task LogoutClick()
    {
        await authStateProvider.Logout();
        navigationManager.NavigateTo("/login");
    }

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IdentityAuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
