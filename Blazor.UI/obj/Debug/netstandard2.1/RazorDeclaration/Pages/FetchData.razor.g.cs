#pragma checksum "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e123adb39c3904b8493a853d7b066454dc703d65"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.UI.Client.Pages
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
#line 2 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
using Blazor.Infra.CrossCutting.SharedUI.ViewModel;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 190 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
       
    public DateTime? Date1 { get; set; } = DateTime.Now.AddDays(-10);
    private string StatusMessage;
    private string StatusClass;
    private EditContext EditContext;
    private WeatherForecastViewModel Model = new WeatherForecastViewModel();
    protected string OkayDisabled { get; set; } = "disabled";
    WeatherForecastViewModel[] forecasts;

    protected void HandleValidSubmit()
    {
        StatusClass = "alert-info";
        StatusMessage = DateTime.Now + " Handle valid submit";
    }

    protected void HandleInvalidSubmit()
    {
        StatusClass = "alert-danger";
        StatusMessage = DateTime.Now + " Handle invalid submit";
    }

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecastViewModel[]>("https://localhost:44301/api/weatherforecast");

        Model = new WeatherForecastViewModel();
        EditContext = new EditContext(Model);
        EditContext.OnFieldChanged += EditContext_OnFieldChanged;

        base.OnInitialized();
    }

    protected override void OnAfterRender(bool param)
    {
        base.OnAfterRender(true);

        SetOkDisabledStatus();
    }

    private void EditContext_OnFieldChanged(object sender, FieldChangedEventArgs e)
    {
        SetOkDisabledStatus();
    }

    private void SetOkDisabledStatus()
    {
        if (EditContext.Validate())
        {
            OkayDisabled = null;
        }
        else
        {
            OkayDisabled = "disabled";
        }
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591