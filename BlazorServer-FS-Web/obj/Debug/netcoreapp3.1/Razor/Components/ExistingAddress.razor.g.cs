#pragma checksum "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\ExistingAddress.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edc5b17b06e35f677f49da4a284422e5b866c1a4"
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
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServer_FS_Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServer_FS_Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServer_FS_Web.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServer_FS_Web.Components.Doors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServer_FS_Web.Components.Invoices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServerLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServerLibrary.Models.Doors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServerLibrary.Models.Jobs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServerLibrary.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServerLibrary.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServerLibrary.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using BlazorServerService.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\_Imports.razor"
using Autofac;

#line default
#line hidden
#nullable disable
    public partial class ExistingAddress : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\ExistingAddress.razor"
                 Address

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\ExistingAddress.razor"
                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "d-flex flex-row existingaddress");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "label");
                __builder2.AddAttribute(9, "class", "p-2");
                __builder2.AddContent(10, 
#nullable restore
#line 3 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\ExistingAddress.razor"
                            Address.Street

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "label");
                __builder2.AddAttribute(13, "class", "p-2");
                __builder2.AddContent(14, 
#nullable restore
#line 4 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\ExistingAddress.razor"
                            Address.TownCity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenElement(16, "label");
                __builder2.AddAttribute(17, "class", "p-2");
                __builder2.AddContent(18, 
#nullable restore
#line 5 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\ExistingAddress.razor"
                            Address.Region

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "label");
                __builder2.AddAttribute(21, "class", "p-2");
                __builder2.AddContent(22, 
#nullable restore
#line 6 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\ExistingAddress.razor"
                            Address.PostCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.AddMarkupContent(24, "<button class=\"btn btn-danger\">Delete</button>\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\ExistingAddress.razor"
       
    [Parameter]
    public Address Address { get; set; }

    [Parameter]
    public EventCallback<Address> OnDelete { get; set; }

    void HandleValidSubmit()
    {
        OnDelete.InvokeAsync(Address);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
