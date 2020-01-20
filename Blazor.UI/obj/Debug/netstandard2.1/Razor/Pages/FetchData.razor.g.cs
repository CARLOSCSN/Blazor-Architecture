#pragma checksum "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e123adb39c3904b8493a853d7b066454dc703d65"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Previsão do tempo</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Este componente demonstra a busca de dados do servidor.</p>\r\n\r\n<br>\r\n\r\n");
#line 11 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Carregando...</em></p>\r\n");
#line 14 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(4, "    ");
            __Blazor.Blazor.UI.Client.Pages.FetchData.TypeInference.CreateMatTable_0(__builder, 5, 6, "mat-elevation-z5 table table-striped table-hover", 7, 
#line 18 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                      forecasts

#line default
#line hidden
            , 8, 
#line 19 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                               true

#line default
#line hidden
            , 9, 
#line 20 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                       true

#line default
#line hidden
            , 10, 
#line 21 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                    150

#line default
#line hidden
            , 11, 
#line 22 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                        5

#line default
#line hidden
            , 12, "Itens por página:", 13, "Página", 14, "Summary", 15, "Pesquisar", 16, (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenElement(18, "th");
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "style", "width:135px;");
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.OpenComponent<MatBlazor.MatButton>(23);
                __builder2.AddAttribute(24, "class", "btn btn-default");
                __builder2.AddAttribute(25, "data-toggle", "modal");
                __builder2.AddAttribute(26, "data-target", "#myModal1");
                __builder2.AddAttribute(27, "Icon", "playlist_add");
                __builder2.AddAttribute(28, "Label", "Adicionar");
                __builder2.AddAttribute(29, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 33 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                       true

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.AddMarkupContent(33, "<th>Summary</th>\r\n            ");
                __builder2.AddMarkupContent(34, "<th>Date</th>\r\n            ");
                __builder2.AddMarkupContent(35, "<th style=\"min-width: 135px;\">Temp. (C)</th>\r\n            ");
                __builder2.AddMarkupContent(36, "<th style=\"min-width: 135px;\">Temp. (F)</th>\r\n        ");
            }
            , 37, (forecast) => (__builder2) => {
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenElement(39, "td");
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatIconButton>(41);
                __builder2.AddAttribute(42, "Icon", "delete");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenElement(45, "td");
                __builder2.AddContent(46, 
#line 46 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                 forecast.Summary

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenElement(48, "td");
                __builder2.AddContent(49, 
#line 47 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                 forecast.Date.ToShortDateString()

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.OpenElement(51, "td");
                __builder2.AddContent(52, 
#line 48 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                 forecast.TemperatureC

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.OpenElement(54, "td");
                __builder2.AddContent(55, 
#line 49 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                 forecast.TemperatureF

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(57, "\r\n");
#line 52 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"

}

#line default
#line hidden
            __builder.AddMarkupContent(58, "\r\n");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "modal fade");
            __builder.AddAttribute(61, "id", "myModal1");
            __builder.AddAttribute(62, "tabindex", "-1");
            __builder.AddAttribute(63, "role", "dialog");
            __builder.AddAttribute(64, "aria-hidden", "true");
            __builder.AddAttribute(65, "style", "display: none;");
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "modal-dialog modal-max");
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "modal-content");
            __builder.AddMarkupContent(72, "\r\n\r\n            ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "panel panel-filled");
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.AddMarkupContent(76, @"<div class=""panel-heading"">
                    <div class=""panel-tools"">
                        <a class=""panel-close"" data-dismiss=""modal""><i class=""fa fa-times""></i></a>
                    </div>
                    <h4 class=""modal-title"">Cadastro de Venda</h4>
                </div>
                <br>
                ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "panel-body");
            __builder.AddMarkupContent(79, "\r\n\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(80);
            __builder.AddAttribute(81, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 69 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                      Model

#line default
#line hidden
            ));
            __builder.AddAttribute(82, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 69 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                             HandleValidSubmit

#line default
#line hidden
            )));
            __builder.AddAttribute(83, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 69 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                                                  HandleInvalidSubmit

#line default
#line hidden
            )));
            __builder.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(85, "\r\n                        ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "alert" + " " + (
#line 70 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                           StatusClass

#line default
#line hidden
                ));
                __builder2.AddContent(88, 
#line 70 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                         StatusMessage

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(90);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(92);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n\r\n                        ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "row");
                __builder2.AddMarkupContent(96, "\r\n                            ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group");
                __builder2.AddMarkupContent(99, "\r\n                                ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "col-lg-2");
                __builder2.AddMarkupContent(102, "\r\n                                    ");
                __builder2.AddMarkupContent(103, "<label for=\"NotaFiscal\">N.F: </label>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(104);
                __builder2.AddAttribute(105, "Id", "NotaFiscal");
                __builder2.AddAttribute(106, "Class", "form-control");
                __builder2.AddAttribute(107, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 79 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                                                  Model.Summary

#line default
#line hidden
                ));
                __builder2.AddAttribute(108, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Summary = __value, Model.Summary))));
                __builder2.AddAttribute(109, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Summary));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "\r\n                                    ");
                __Blazor.Blazor.UI.Client.Pages.FetchData.TypeInference.CreateValidationMessage_1(__builder2, 111, 112, 
#line 80 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                              () => Model.Summary

#line default
#line hidden
                );
                __builder2.AddMarkupContent(113, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                                ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "col-lg-3");
                __builder2.AddMarkupContent(117, "\r\n                                    ");
                __builder2.OpenElement(118, "p");
                __builder2.AddMarkupContent(119, "\r\n                                        ");
                __builder2.AddMarkupContent(120, "<label for=\"Data\">Data</label>\r\n                                        ");
                __Blazor.Blazor.UI.Client.Pages.FetchData.TypeInference.CreateMatDatePicker_2(__builder2, 121, 122, 
#line 85 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                 true

#line default
#line hidden
                , 123, 
#line 87 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                   false

#line default
#line hidden
                , 124, "dd/MM/yyyy", 125, 
#line 86 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                    Date1

#line default
#line hidden
                , 126, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Date1 = __value, Date1)), 127, () => Date1);
                __builder2.AddMarkupContent(128, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                                ");
                __builder2.OpenElement(131, "div");
                __builder2.AddAttribute(132, "class", "col-lg-5");
                __builder2.AddMarkupContent(133, "\r\n                                    ");
                __builder2.AddMarkupContent(134, "<label for=\"Cliente\">Cliente: </label>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(135);
                __builder2.AddAttribute(136, "Id", "Cliente");
                __builder2.AddAttribute(137, "Class", "form-control");
                __builder2.AddAttribute(138, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 94 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                                               Model.Summary

#line default
#line hidden
                ));
                __builder2.AddAttribute(139, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Summary = __value, Model.Summary))));
                __builder2.AddAttribute(140, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Summary));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(141, "\r\n                                    ");
                __Blazor.Blazor.UI.Client.Pages.FetchData.TypeInference.CreateValidationMessage_3(__builder2, 142, 143, 
#line 95 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                              () => Model.Summary

#line default
#line hidden
                );
                __builder2.AddMarkupContent(144, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n                                ");
                __builder2.AddMarkupContent(146, @"<div class=""col-lg-2"">
                                    <label for=""ValorCompra"">Valor de Venda</label>
                                    <input type=""text"" class=""form-control"" id=""ValorVenda"" name=""ValorVenda"" placeholder=""Valor de Venda"">
                                </div>
                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n                        <br>\r\n                        ");
                __builder2.AddMarkupContent(149, "<div class=\"row\">\r\n                            <div class=\"form-group\">\r\n                                <div class=\"col-lg-2\">\r\n                                    <label for=\"ValorCompra\">Valor de Compra</label>\r\n                                    <input type=\"text\" class=\"form-control\" id=\"ValorCompra\" name=\"ValorCompra\" placeholder=\"Valor de Compra\">\r\n                                </div>\r\n                                <div class=\"col-lg-1\">\r\n                                    <label for=\"Imposto\">% Imposto</label>\r\n                                    <input type=\"text\" class=\"form-control\" id=\"Imposto\" name=\"Imposto\" placeholder=\"% Imp.\">\r\n                                </div>\r\n                                <div class=\"col-lg-2\">\r\n                                    <label for=\"Frete1\">Frete 01</label>\r\n                                    <input type=\"text\" class=\"form-control\" id=\"Frete1\" name=\"Frete1\" placeholder=\"Frete 01\">\r\n                                </div>\r\n                                <div class=\"col-lg-2\">\r\n                                    <label for=\"Frete2\">Frete 02</label>\r\n                                    <input type=\"text\" class=\"form-control\" id=\"Frete2\" name=\"Frete2\" placeholder=\"Frete 02\">\r\n                                </div>\r\n                                <div class=\"col-lg-1\">\r\n                                    <label for=\"CustoOperacional\">% C.O</label>\r\n                                    <input type=\"text\" class=\"form-control\" id=\"CustoOperacional\" name=\"CustoOperacional\" placeholder=\"% C.O\">\r\n                                </div>\r\n                                <div class=\"col-lg-2\">\r\n                                    <label for=\"OutrasDespesas\">Outras Despesas</label>\r\n                                    <input type=\"text\" class=\"form-control\" id=\"OutrasDespesas\" name=\"OutrasDespesas\" placeholder=\"Outras Despesas\">\r\n                                </div>\r\n                                <div class=\"col-lg-2\">\r\n                                    <label for=\"CustoTotal\">Custo Total</label>\r\n                                    <input type=\"text\" class=\"form-control\" id=\"CustoTotal\" name=\"CustoTotal\" placeholder=\"Custo Total\">\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <br>\r\n                        ");
                __builder2.AddMarkupContent(150, "<div class=\"row\">\r\n                            <div class=\"form-group\">\r\n                                <div class=\"col-lg-2\">\r\n                                    <label for=\"PercentualComissao\">% Comissão</label>\r\n                                    <input type=\"text\" class=\"form-control\" id=\"PercentualComissao\" name=\"PercentualComissao\" placeholder=\"% Comissão\">\r\n                                </div>\r\n                                <div class=\"col-lg-2\">\r\n                                    <label for=\"ValorComissao\">Valor Comissão</label>\r\n                                    <input type=\"text\" class=\"form-control\" id=\"ValorComissao\" name=\"ValorComissao\" placeholder=\"Valor de Comissão\">\r\n                                </div>\r\n                                <div class=\"col-lg-2\">\r\n                                    <label for=\"PercentualLucro\">% Lucro</label>\r\n                                    <input type=\"text\" class=\"form-control\" id=\"PercentualLucro\" name=\"PercentualLucro\" placeholder=\"% Lucro\">\r\n                                </div>\r\n                                <div class=\"col-lg-2\">\r\n                                    <label for=\"ValorLucro\">Valor Lucro</label>\r\n                                    <input type=\"text\" class=\"form-control\" id=\"ValorLucro\" name=\"ValorLucro\" placeholder=\"Valor de Lucro\">\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <br>\r\n                        ");
                __builder2.AddMarkupContent(151, @"<div class=""row"">
                            <div class=""form-group"">
                                <div class=""col-lg-12"">
                                    <label for=""Descricao"">Descrição</label>
                                    <textarea class=""form-control"" rows=""3"" placeholder=""Descrição""></textarea>
                                </div>
                            </div>
                        </div>
                        <br>
                        ");
                __builder2.AddMarkupContent(152, "<div class=\"row\">\r\n                        </div>\r\n\r\n                        ");
                __builder2.OpenElement(153, "div");
                __builder2.AddAttribute(154, "class", "pull-right");
                __builder2.AddMarkupContent(155, "\r\n                            ");
                __builder2.OpenElement(156, "button");
                __builder2.AddAttribute(157, "type", "submit");
                __builder2.AddAttribute(158, "class", "btn btn-accent");
                __builder2.AddAttribute(159, "disabled", 
#line 178 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                                    OkayDisabled

#line default
#line hidden
                );
                __builder2.AddContent(160, "Salvar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n                        <br>\r\n\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(163, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n");
            __builder.CloseElement();
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
namespace __Blazor.Blazor.UI.Client.Pages.FetchData
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTable_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TableItem> __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Int32 __arg4, int __seq5, global::System.Int32 __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.String __arg7, int __seq8, global::System.String __arg8, int __seq9, global::System.String __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment __arg10, int __seq11, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg11)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "Items", __arg1);
        __builder.AddAttribute(__seq2, "LoadInitialData", __arg2);
        __builder.AddAttribute(__seq3, "Striped", __arg3);
        __builder.AddAttribute(__seq4, "DebounceMilliseconds", __arg4);
        __builder.AddAttribute(__seq5, "PageSize", __arg5);
        __builder.AddAttribute(__seq6, "PageRecordCountLabel", __arg6);
        __builder.AddAttribute(__seq7, "PageLabel", __arg7);
        __builder.AddAttribute(__seq8, "FilterByColumnName", __arg8);
        __builder.AddAttribute(__seq9, "SearchTermFieldLabel", __arg9);
        __builder.AddAttribute(__seq10, "MatTableHeader", __arg10);
        __builder.AddAttribute(__seq11, "MatTableRow", __arg11);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMatDatePicker_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Required", __arg0);
        __builder.AddAttribute(__seq1, "AllowInput", __arg1);
        __builder.AddAttribute(__seq2, "Format", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
