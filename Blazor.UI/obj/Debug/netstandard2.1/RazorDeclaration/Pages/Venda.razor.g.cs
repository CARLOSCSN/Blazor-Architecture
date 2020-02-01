#pragma checksum "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\Venda.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17d7f3fc9841526809793daa485454146e50bc18"
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
#line 18 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using Client.Services.Implementations;

#line default
#line hidden
#line 20 "C:\Temp\Blazor-Architecture\Blazor.UI\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#line 2 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\Venda.razor"
using Common.ViewModel;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/venda")]
    public partial class Venda : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 216 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\Venda.razor"
       
    private EditContext EditContext;
    private VendaViewModel Model = new VendaViewModel();
    private VendaViewModel[] vendas;
    private bool ModalOpen { get; set; }
    private string modalTitle { get; set; }

    protected async Task HandleValidSubmit()
    {
        try
        {
            await webApiServices.Post<VendaViewModel>(Model, "api/Venda");
            navigationManager.NavigateTo("/venda");

            closeModal();
            matToaster.Add("Venda cadastrada.", MatToastType.Success, "Sucesso");
            vendas = await Http.GetJsonAsync<VendaViewModel[]>("https://localhost:44301/api/Venda");
            StateHasChanged();
        }
        catch (Exception ex)
        {
            matToaster.Add(ex.Message, MatToastType.Danger, "Erro");
            Console.WriteLine(ex.Message);
        }
    }

    protected void HandleInvalidSubmit()
    {
        matToaster.Add("Não foi possivel realizar o cadastro.", MatToastType.Warning, "Atenção");
    }

    protected override async Task OnInitializedAsync()
    {

        vendas = await Http.GetJsonAsync<VendaViewModel[]>("https://localhost:44301/api/Venda");
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
        var validator = EditContextFluentValidationExtensions.GetValidatorForModel(Model);
        var validationResults = validator.Validate(Model);
        var isInvalid = validationResults.Errors.Count == 0 ? false : true;
        //Console.WriteLine(validationResults.Errors.Count);

        var task = controlInputTypeSubmit(isInvalid);
        task.GetAwaiter();
    }

    protected void openModal(int hash)
    {
        this.Model = new VendaViewModel();
        this.modalTitle = "Cadastro de Venda";
        this.ModalOpen = true;

    }

    protected void closeModal()
    {
        this.ModalOpen = false;
        StateHasChanged();
    }

    // Call Functions Jquery
    private async Task controlInputTypeSubmit(bool isInvalid)
    {
        var result = await JSRuntime.InvokeAsync<bool>("controlInputTypeSubmit", isInvalid);

        StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster matToaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WebApiServices webApiServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
