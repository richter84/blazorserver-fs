#pragma checksum "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\ExistingAddress.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "598e539c3b3992d0c4d96b7dd674f067bc175148"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class ExistingAddress : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
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
