#pragma checksum "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e267789411299394cc6df62d8ac9334468b1a284"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
using Common.ViewModel;

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
#line 12 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Carregando...</em></p>\r\n");
#line 15 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(4, "    ");
            __Blazor.Client.Pages.FetchData.TypeInference.CreateMatTable_0(__builder, 5, 6, "mat-elevation-z5 table table-striped table-hover", 7, 
#line 19 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                      forecasts

#line default
#line hidden
            , 8, 
#line 20 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                               true

#line default
#line hidden
            , 9, 
#line 21 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                       true

#line default
#line hidden
            , 10, 
#line 22 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                    150

#line default
#line hidden
            , 11, 
#line 23 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
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
                __builder2.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 32 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                            () => openModal(1)

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "Icon", "playlist_add");
                __builder2.AddAttribute(27, "Label", "Adicionar");
                __builder2.AddAttribute(28, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 35 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                       true

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.AddMarkupContent(32, "<th>Summary</th>\r\n            ");
                __builder2.AddMarkupContent(33, "<th>Date</th>\r\n            ");
                __builder2.AddMarkupContent(34, "<th style=\"min-width: 135px;\">Temp. (C)</th>\r\n            ");
                __builder2.AddMarkupContent(35, "<th style=\"min-width: 135px;\">Temp. (F)</th>\r\n        ");
            }
            , 36, (forecast) => (__builder2) => {
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.OpenElement(38, "td");
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatIconButton>(40);
                __builder2.AddAttribute(41, "Icon", "delete");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.OpenElement(44, "td");
                __builder2.AddContent(45, 
#line 48 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                 forecast.Summary

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenElement(47, "td");
                __builder2.AddContent(48, 
#line 49 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                 forecast.Date.ToShortDateString()

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenElement(50, "td");
                __builder2.AddContent(51, 
#line 50 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                 forecast.TemperatureC

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __builder2.OpenElement(53, "td");
                __builder2.AddContent(54, 
#line 51 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                 forecast.TemperatureF

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(56, "\r\n");
#line 54 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"

}

#line default
#line hidden
            __builder.AddMarkupContent(57, "\r\n");
#line 57 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
 if (ModalOpen)
{

#line default
#line hidden
            __builder.AddContent(58, "    ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "modal");
            __builder.AddAttribute(61, "tabindex", "-1");
            __builder.AddAttribute(62, "style", "display:block");
            __builder.AddAttribute(63, "role", "dialog");
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "modal-dialog modal-max");
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "modal-content");
            __builder.AddMarkupContent(70, "\r\n\r\n                ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "panel panel-filled");
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "panel-heading");
            __builder.AddMarkupContent(76, "\r\n                        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "panel-tools");
            __builder.AddMarkupContent(79, "\r\n                            ");
            __builder.OpenElement(80, "a");
            __builder.AddAttribute(81, "class", "panel-close");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 66 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                             closeModal

#line default
#line hidden
            ));
            __builder.AddMarkupContent(83, "<i class=\"fa fa-times\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.OpenElement(86, "h4");
            __builder.AddAttribute(87, "class", "modal-title");
            __builder.AddContent(88, 
#line 68 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                 modalTitle

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                    <br>\r\n                    ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "panel-body");
            __builder.AddMarkupContent(93, "\r\n\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(94);
            __builder.AddAttribute(95, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 73 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                          Model

#line default
#line hidden
            ));
            __builder.AddAttribute(96, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 73 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                 HandleValidSubmit

#line default
#line hidden
            )));
            __builder.AddAttribute(97, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 73 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                                                      HandleInvalidSubmit

#line default
#line hidden
            )));
            __builder.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(99, "\r\n                            ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "alert" + " " + (
#line 74 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                               StatusClass

#line default
#line hidden
                ));
                __builder2.AddContent(102, 
#line 74 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                             StatusMessage

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n\r\n                            ");
                __builder2.OpenComponent<Common.Validation.FluentValidationValidator>(104);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(106);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\r\n\r\n                            ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "row");
                __builder2.AddMarkupContent(110, "\r\n                                ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "form-group");
                __builder2.AddMarkupContent(113, "\r\n                                    ");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "col-lg-2");
                __builder2.AddMarkupContent(116, "\r\n                                        ");
                __builder2.AddMarkupContent(117, "<label for=\"NotaFiscal\">N.F: </label>\r\n                                        ");
                __Blazor.Client.Pages.FetchData.TypeInference.CreateInputDate_1(__builder2, 118, 119, "NotaFiscal", 120, "form-control", 121, 
#line 83 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                                                      Model.Date

#line default
#line hidden
                , 122, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Date = __value, Model.Date)), 123, () => Model.Date);
                __builder2.AddMarkupContent(124, "\r\n                                            ");
                __Blazor.Client.Pages.FetchData.TypeInference.CreateValidationMessage_2(__builder2, 125, 126, 
#line 84 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                      () => Model.Date

#line default
#line hidden
                );
                __builder2.AddMarkupContent(127, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n                                    ");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "col-lg-3");
                __builder2.AddMarkupContent(131, "\r\n                                        ");
                __builder2.OpenElement(132, "p");
                __builder2.AddMarkupContent(133, "\r\n                                            ");
                __builder2.AddMarkupContent(134, "<label for=\"Data\">Data</label>\r\n                                            ");
                __Blazor.Client.Pages.FetchData.TypeInference.CreateMatDatePicker_3(__builder2, 135, 136, 
#line 89 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                     true

#line default
#line hidden
                , 137, 
#line 91 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                       false

#line default
#line hidden
                , 138, "dd/MM/yyyy", 139, 
#line 90 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                        Date1

#line default
#line hidden
                , 140, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Date1 = __value, Date1)), 141, () => Date1);
                __builder2.AddMarkupContent(142, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\r\n                                    ");
                __builder2.OpenElement(145, "div");
                __builder2.AddAttribute(146, "class", "col-lg-5");
                __builder2.AddMarkupContent(147, "\r\n                                        ");
                __builder2.AddMarkupContent(148, "<label for=\"Cliente\">Cliente: </label>\r\n                                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(149);
                __builder2.AddAttribute(150, "Id", "Cliente");
                __builder2.AddAttribute(151, "Class", "form-control");
                __builder2.AddAttribute(152, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 98 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                                                   Model.Summary

#line default
#line hidden
                ));
                __builder2.AddAttribute(153, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Summary = __value, Model.Summary))));
                __builder2.AddAttribute(154, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Summary));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(155, "\r\n                                        ");
                __Blazor.Client.Pages.FetchData.TypeInference.CreateValidationMessage_4(__builder2, 156, 157, 
#line 99 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
                                                                  () => Model.Summary

#line default
#line hidden
                );
                __builder2.AddMarkupContent(158, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\r\n                                    ");
                __builder2.AddMarkupContent(160, @"<div class=""col-lg-2"">
                                        <label for=""ValorCompra"">Valor de Venda</label>
                                        <input type=""text"" class=""form-control"" id=""ValorVenda"" name=""ValorVenda"" placeholder=""Valor de Venda"">
                                    </div>
                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n                            <br>\r\n                            ");
                __builder2.AddMarkupContent(163, "<div class=\"row\">\r\n                                <div class=\"form-group\">\r\n                                    <div class=\"col-lg-2\">\r\n                                        <label for=\"ValorCompra\">Valor de Compra</label>\r\n                                        <input type=\"text\" class=\"form-control\" id=\"ValorCompra\" name=\"ValorCompra\" placeholder=\"Valor de Compra\">\r\n                                    </div>\r\n                                    <div class=\"col-lg-1\">\r\n                                        <label for=\"Imposto\">% Imposto</label>\r\n                                        <input type=\"text\" class=\"form-control\" id=\"Imposto\" name=\"Imposto\" placeholder=\"% Imp.\">\r\n                                    </div>\r\n                                    <div class=\"col-lg-2\">\r\n                                        <label for=\"Frete1\">Frete 01</label>\r\n                                        <input type=\"text\" class=\"form-control\" id=\"Frete1\" name=\"Frete1\" placeholder=\"Frete 01\">\r\n                                    </div>\r\n                                    <div class=\"col-lg-2\">\r\n                                        <label for=\"Frete2\">Frete 02</label>\r\n                                        <input type=\"text\" class=\"form-control\" id=\"Frete2\" name=\"Frete2\" placeholder=\"Frete 02\">\r\n                                    </div>\r\n                                    <div class=\"col-lg-1\">\r\n                                        <label for=\"CustoOperacional\">% C.O</label>\r\n                                        <input type=\"text\" class=\"form-control\" id=\"CustoOperacional\" name=\"CustoOperacional\" placeholder=\"% C.O\">\r\n                                    </div>\r\n                                    <div class=\"col-lg-2\">\r\n                                        <label for=\"OutrasDespesas\">Outras Despesas</label>\r\n                                        <input type=\"text\" class=\"form-control\" id=\"OutrasDespesas\" name=\"OutrasDespesas\" placeholder=\"Outras Despesas\">\r\n                                    </div>\r\n                                    <div class=\"col-lg-2\">\r\n                                        <label for=\"CustoTotal\">Custo Total</label>\r\n                                        <input type=\"text\" class=\"form-control\" id=\"CustoTotal\" name=\"CustoTotal\" placeholder=\"Custo Total\">\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <br>\r\n                            ");
                __builder2.AddMarkupContent(164, "<div class=\"row\">\r\n                                <div class=\"form-group\">\r\n                                    <div class=\"col-lg-2\">\r\n                                        <label for=\"PercentualComissao\">% Comissão</label>\r\n                                        <input type=\"text\" class=\"form-control\" id=\"PercentualComissao\" name=\"PercentualComissao\" placeholder=\"% Comissão\">\r\n                                    </div>\r\n                                    <div class=\"col-lg-2\">\r\n                                        <label for=\"ValorComissao\">Valor Comissão</label>\r\n                                        <input type=\"text\" class=\"form-control\" id=\"ValorComissao\" name=\"ValorComissao\" placeholder=\"Valor de Comissão\">\r\n                                    </div>\r\n                                    <div class=\"col-lg-2\">\r\n                                        <label for=\"PercentualLucro\">% Lucro</label>\r\n                                        <input type=\"text\" class=\"form-control\" id=\"PercentualLucro\" name=\"PercentualLucro\" placeholder=\"% Lucro\">\r\n                                    </div>\r\n                                    <div class=\"col-lg-2\">\r\n                                        <label for=\"ValorLucro\">Valor Lucro</label>\r\n                                        <input type=\"text\" class=\"form-control\" id=\"ValorLucro\" name=\"ValorLucro\" placeholder=\"Valor de Lucro\">\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <br>\r\n                            ");
                __builder2.AddMarkupContent(165, @"<div class=""row"">
                                <div class=""form-group"">
                                    <div class=""col-lg-12"">
                                        <label for=""Descricao"">Descrição</label>
                                        <textarea class=""form-control"" rows=""3"" placeholder=""Descrição""></textarea>
                                    </div>
                                </div>
                            </div>
                            <br>
                            ");
                __builder2.AddMarkupContent(166, "<div class=\"row\">\r\n                            </div>\r\n\r\n                            ");
                __builder2.AddMarkupContent(167, "<div class=\"pull-right\">\r\n                                <button type=\"submit\" class=\"btn btn-accent\">Salvar</button>\r\n                            </div>\r\n                            <br>\r\n\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(168, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n");
#line 193 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 195 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\FetchData.razor"
       
    public DateTime? Date1 { get; set; } = DateTime.Now.AddDays(-10);
    private string StatusMessage;
    private string StatusClass;
    private EditContext EditContext;
    private WeatherForecastViewModel Model = new WeatherForecastViewModel();
    WeatherForecastViewModel[] forecasts;
    bool ModalOpen { get; set; }
    string modalTitle { get; set; }

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

    void openModal(int hash)
    {
        this.Model = new WeatherForecastViewModel();
        this.modalTitle = "Cadastro de Venda";
        this.ModalOpen = true;

    }
    protected void closeModal()
    {
        this.ModalOpen = false;
    }

    // Call Functions Jquery
    private async Task controlInputTypeSubmit(bool isInvalid)
    {
        var result = await JSRuntime.InvokeAsync<bool>("controlInputTypeSubmit", isInvalid);

        StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Client.Pages.FetchData
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
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Id", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMatDatePicker_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
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
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
