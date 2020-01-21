#pragma checksum "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0784fd527933e60d33f23f4c4758052aa5b66da9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.Pages
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
#line 11 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using FluentValidation;

#line default
#line hidden
#line 13 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Shared;

#line default
#line hidden
#line 14 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Client;

#line default
#line hidden
#line 15 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Common;

#line default
#line hidden
#line 16 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Common.Validation;

#line default
#line hidden
#line 17 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Client.Services.Contracts;

#line default
#line hidden
#line 20 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#line 2 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\Register.razor"
using Client.Services.Implementations;

#line default
#line hidden
#line 3 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\Register.razor"
using Common.ViewModel;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 36 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\Register.razor"
           

    RegisterParametersViewModel registerParameters { get; set; } = new RegisterParametersViewModel();
    string error { get; set; }

    async Task OnSubmit()
    {
        error = null;
        try
        {
            await authStateProvider.Register(registerParameters);
            navigationManager.NavigateTo("");
        }
        catch (Exception ex)
        {
            error = ex.Message;
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IdentityAuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
