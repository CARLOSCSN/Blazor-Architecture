#pragma checksum "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\SwInputText.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "627ad50dc70780a9794a01fdaf5c49ec924e357a"
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
#line 1 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\SwInputText.razor"
using System.Linq.Expressions;

#line default
#line hidden
#line 2 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\SwInputText.razor"
using System.Globalization;

#line default
#line hidden
    public partial class SwInputText<T> : InputBase<T>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-control-wrapper");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "label");
            __builder.AddAttribute(4, "class", "form-control-label");
            __builder.AddAttribute(5, "for", 
#line 9 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\SwInputText.razor"
                                            uniqueId

#line default
#line hidden
            );
            __builder.AddContent(6, 
#line 9 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\SwInputText.razor"
                                                       Label

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "class", "form-control" + " " + (
#line 10 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\SwInputText.razor"
                                CssClass

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "id", 
#line 10 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\SwInputText.razor"
                                               uniqueId

#line default
#line hidden
            );
            __builder.AddAttribute(11, "name", 
#line 10 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\SwInputText.razor"
                                                                Name

#line default
#line hidden
            );
            __builder.AddAttribute(12, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#line 11 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\SwInputText.razor"
                         OnFocusOutFunc

#line default
#line hidden
            ));
            __builder.AddAttribute(13, "readonly", 
#line 13 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\SwInputText.razor"
                      Readonly

#line default
#line hidden
            );
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 12 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\SwInputText.razor"
                        CurrentValueAsString

#line default
#line hidden
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentValueAsString = __value, CurrentValueAsString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-control-validation");
            __builder.AddMarkupContent(19, "\r\n        ");
            __Blazor.Client.Pages.SwInputText.TypeInference.CreateValidationMessage_0(__builder, 20, 21, 
#line 15 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\SwInputText.razor"
                                 ValidationFor

#line default
#line hidden
            );
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 20 "C:\Temp\Blazor-Architecture\Blazor.UI\Pages\SwInputText.razor"
       

    [Parameter] public string Id { get; set; }
    [Parameter] public string Label { get; set; }
    [Parameter] public string Name { get; set; }
    [Parameter] public Expression<Func<T>> ValidationFor { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter] public bool ShowDefaultOpton { get; set; } = true;
    [Parameter] public bool Readonly { get; set; } = false;
    [Parameter] public EventCallback OnFocusOutFunc { get; set; }

    private string uniqueId = Guid.NewGuid().ToString("N");

    protected override bool TryParseValueFromString(string value, out T result, out string validationErrorMessage)
    {
        if (typeof(T) == typeof(string))
        {
            result = (T)(object)value;
            validationErrorMessage = null;

            return true;
        }
        else if (typeof(T) == typeof(int))
        {
            int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsedValue);
            result = (T)(object)parsedValue;
            validationErrorMessage = null;

            return true;
        }
        else if (typeof(T) == typeof(decimal))
        {
            decimal.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var parsedValue);
            result = (T)(object)parsedValue;
            validationErrorMessage = null;

            return true;
        }
        else if (typeof(T) == typeof(double))
        {
            double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var parsedValue);
            result = (T)(object)parsedValue;
            validationErrorMessage = null;

            return true;
        }
        else if (typeof(T) == typeof(Guid))
        {
            Guid.TryParse(value, out var parsedValue);
            result = (T)(object)parsedValue;
            validationErrorMessage = null;

            return true;
        }
        else if (typeof(T).IsEnum)
        {
            // There's no non-generic Enum.TryParse (https://github.com/dotnet/corefx/issues/692)
            try
            {
                result = (T)Enum.Parse(typeof(T), value);
                validationErrorMessage = null;

                return true;
            }
            catch (ArgumentException)
            {
                result = default;
                validationErrorMessage = $"The {FieldIdentifier.FieldName} field is not valid.";

                return false;
            }
        }

        throw new InvalidOperationException($"{GetType()} does not support the type '{typeof(T)}'.");
    }


#line default
#line hidden
    }
}
namespace __Blazor.Client.Pages.SwInputText
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
