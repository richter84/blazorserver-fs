#pragma checksum "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\AddAddress.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca56356c4b7717b0b21ffa456d9132aad5a71140"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer_FS_Web.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServer_FS_Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServer_FS_Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServer_FS_Web.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServer_FS_Web.Components.Doors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServerLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServerLibrary.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServerLibrary.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServerService.Interfaces;

#line default
#line hidden
#nullable disable
    public partial class AddAddress : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Addresses</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\AddAddress.razor"
                 Address

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\AddAddress.razor"
                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<label for=\"Street\">Street</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "id", "Street");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\AddAddress.razor"
                               Address.Street

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.Street = __value, Address.Street))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Address.Street));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __Blazor.BlazorServer_FS_Web.Components.AddAddress.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 8 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\AddAddress.razor"
                                () => Address.Street

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-row");
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.AddMarkupContent(29, "<label for=\"TownCity\">Town or City</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "id", "TownCity");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\AddAddress.razor"
                                   Address.TownCity

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.TownCity = __value, Address.TownCity))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Address.TownCity));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __Blazor.BlazorServer_FS_Web.Components.AddAddress.TypeInference.CreateValidationMessage_1(__builder2, 37, 38, 
#nullable restore
#line 14 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\AddAddress.razor"
                                    () => Address.TownCity

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.AddMarkupContent(44, "<label for=\"Region\">Region</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "id", "Region");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\AddAddress.razor"
                                   Address.Region

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.Region = __value, Address.Region))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Address.Region));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __Blazor.BlazorServer_FS_Web.Components.AddAddress.TypeInference.CreateValidationMessage_2(__builder2, 52, 53, 
#nullable restore
#line 19 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\AddAddress.razor"
                                    () => Address.Region

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group col-md-2");
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.AddMarkupContent(59, "<label for=\"PostCode\">Post Code</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "id", "PostCode");
                __builder2.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\AddAddress.razor"
                                   Address.PostCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.PostCode = __value, Address.PostCode))));
                __builder2.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Address.PostCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __Blazor.BlazorServer_FS_Web.Components.AddAddress.TypeInference.CreateValidationMessage_3(__builder2, 67, 68, 
#nullable restore
#line 24 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\AddAddress.razor"
                                    () => Address.PostCode

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.AddMarkupContent(72, "<button class=\"btn btn-primary\">Add Address</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\AddAddress.razor"
       

    [Parameter]
    public EventCallback<Address> OnAdd { get; set; }

    [Parameter]
    public Address Address { get; set; }

    void HandleValidSubmit()
    {
        OnAdd.InvokeAsync(Address);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorServer_FS_Web.Components.AddAddress
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
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
