#pragma checksum "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ded31917a97124101149c302cafd44114af4d69"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Customer/{CustomerId:int}/Job")]
    public partial class Job : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Job</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-md-8");
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "state-map-container");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "state");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "state-icon" + " " + (
#nullable restore
#line 10 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                                    IsPendingComplete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "\r\n                <span class=\"oi oi-lock-unlocked\"></span>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "h3");
            __builder.AddAttribute(15, "class", 
#nullable restore
#line 13 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                        IsPendingComplete

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, "Pending");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.AddMarkupContent(18, "<p>\r\n                Tue 18 June 2020\r\n                <br>10:03am\r\n            </p>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "state-line" + " " + (
#nullable restore
#line 19 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                                IsJobComplete

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "state");
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "state-icon" + " " + (
#nullable restore
#line 21 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                                    IsJobComplete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                <span class=\"oi oi-lock-locked\"></span>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "h3");
            __builder.AddAttribute(31, "class", 
#nullable restore
#line 24 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                        IsJobComplete

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, "Complete");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.AddMarkupContent(34, "<p>\r\n                Tue 18 June 2020\r\n                <br>10:15am\r\n            </p>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "state-line" + " " + (
#nullable restore
#line 30 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                                IsApprovedComplete

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "state");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "state-icon" + " " + (
#nullable restore
#line 32 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                                    IsApprovedComplete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "\r\n                <span class=\"oi oi-check\"></span>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "h3");
            __builder.AddAttribute(47, "class", 
#nullable restore
#line 35 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                        IsApprovedComplete

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(48, "Approved");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.AddMarkupContent(50, "<p>\r\n                Thu 20 June 2020\r\n                <br>7:45am\r\n            </p>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "state-line" + " " + (
#nullable restore
#line 41 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                                IsInvoicedComplete

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "state");
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "state-icon" + " " + (
#nullable restore
#line 43 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                                    IsInvoicedComplete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(60, "\r\n                <span class=\"oi oi-document\"></span>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "h3");
            __builder.AddAttribute(63, "class", 
#nullable restore
#line 46 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                        IsInvoicedComplete

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(64, "Invoiced");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.AddMarkupContent(66, "<p>\r\n                Fri 21 June 2020\r\n                <br>3:21pm\r\n            </p>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "state-line" + " " + (
#nullable restore
#line 52 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                                IsPaidComplete

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "state");
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "state-icon" + " " + (
#nullable restore
#line 54 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                                    IsPaidComplete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(76, "\r\n                <span class=\"oi oi-british-pound\"></span>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.OpenElement(78, "h3");
            __builder.AddAttribute(79, "class", 
#nullable restore
#line 57 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                        IsPaidComplete

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(80, "Paid");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.AddMarkupContent(82, "<p>\r\n                Awaiting Payment\r\n                <br><br>\r\n            </p>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\r\n    <div></div>\r\n    ");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "class", "btn btn-primary");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                                              HandleUpdateState

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.AddContent(89, 
#nullable restore
#line 67 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
         ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(90, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n    <div></div><br><br>\r\n    ");
            __builder.OpenElement(92, "section");
            __builder.AddMarkupContent(93, "\r\n        ");
            __builder.OpenElement(94, "fieldset");
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.AddMarkupContent(96, "<legend>\r\n                Customer Detail\r\n            </legend>\r\n            ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "row");
            __builder.AddMarkupContent(99, "\r\n                ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "col-sm-12");
            __builder.AddMarkupContent(102, "\r\n                    ");
            __builder.AddContent(103, 
#nullable restore
#line 77 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                     Customer.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(104, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "col-sm-6");
            __builder.AddMarkupContent(108, "\r\n                    ");
            __builder.AddContent(109, 
#nullable restore
#line 80 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                     Customer.EmailAddress

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "col-sm-6");
            __builder.AddMarkupContent(114, "\r\n                    ");
            __builder.AddContent(115, 
#nullable restore
#line 83 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                     Customer.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(116, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n    <br><br>\r\n    ");
            __builder.OpenElement(121, "section");
            __builder.AddMarkupContent(122, "\r\n        ");
            __builder.OpenElement(123, "fieldset");
            __builder.AddMarkupContent(124, "\r\n            ");
            __builder.AddMarkupContent(125, "<legend>\r\n                Select Door\r\n            </legend>\r\n            ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "form-group");
            __builder.AddMarkupContent(128, "\r\n                ");
            __builder.OpenElement(129, "select");
            __builder.AddAttribute(130, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                                   HandleDoorTypeChange

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(131, "class", "btn btn-primary");
            __builder.AddMarkupContent(132, "\r\n                    ");
            __builder.OpenElement(133, "option");
            __builder.AddContent(134, "Door Type ...");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                    ");
            __builder.OpenElement(136, "option");
            __builder.AddAttribute(137, "style", "background-color:none; padding:5px;");
            __builder.AddContent(138, "Roller Shutter");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                    ");
            __builder.OpenElement(140, "option");
            __builder.AddAttribute(141, "disabled", true);
            __builder.AddContent(142, "Sectional");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                    ");
            __builder.OpenElement(144, "option");
            __builder.AddAttribute(145, "disabled", true);
            __builder.AddContent(146, "Pedestrian");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                    ");
            __builder.OpenElement(148, "option");
            __builder.AddAttribute(149, "disabled", true);
            __builder.AddContent(150, "Gates");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                    ");
            __builder.OpenElement(152, "option");
            __builder.AddAttribute(153, "disabled", true);
            __builder.AddContent(154, "Bars / Grilles");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n        ");
            __builder.OpenElement(159, "div");
            __builder.AddAttribute(160, "class", 
#nullable restore
#line 105 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                     Display

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(161, "\r\n            ");
            __builder.OpenComponent<BlazorServer_FS_Web.Components.Doors.RollerShutter>(162);
            __builder.CloseComponent();
            __builder.AddMarkupContent(163, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n    <br><br>\r\n    ");
            __builder.AddMarkupContent(166, @"<section>
        <fieldset>
            <legend>
                Handover
            </legend>
            <form>
                <div class=""form-group"">
                    <label for=""startdate"">Start Date</label>
                </div>
                <div class=""form-group"">
                    <label for=""enddate"">End Date</label>
                </div>
            </form>
        </fieldset>
    </section>
    <br><br>
    ");
            __builder.OpenElement(167, "section");
            __builder.AddAttribute(168, "class", 
#nullable restore
#line 126 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
                     DisplayInvoiceItems

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(169, "\r\n        ");
            __builder.AddMarkupContent(170, "<fieldset>\r\n            <legend>\r\n                Invoice Items\r\n            </legend>\r\n            <form>\r\n            </form>\r\n        </fieldset>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 138 "C:\Users\nncri\source\repos\BlazorServer-FS\BlazorServer-FS-Web\Components\Job.razor"
       

    [Parameter]
    public int CustomerId { get; set; }

    public Customer Customer { get; set; } = new Customer() { Address = new List<Address>() };

    private string IsPendingComplete;
    private string IsJobComplete;
    private string IsApprovedComplete;
    private string IsInvoicedComplete;
    private string IsPaidComplete;

    private int stateIndex = 1;
    private JobStatus State;

    private const string IsComplete = "complete";

    private string ButtonText = "Save Job";

    private string Display = "d-none";
    private string DisplayInvoiceItems = "d-none";

    protected override async Task OnInitializedAsync()
    {
        Customer = await CustomerService.GetCustomer(CustomerId);
    }

    private void HandleUpdateState()
    {
        State = (JobStatus)Enum.ToObject(typeof(JobStatus), stateIndex++);

        switch (State)
        {
            case JobStatus.Pending:
                IsPendingComplete = IsComplete;
                ButtonText = "Complete Job";
                break;
            case JobStatus.Complete:
                IsJobComplete = IsComplete;
                ButtonText = "Approve Job";
                break;
            case JobStatus.Approved:
                IsApprovedComplete = IsComplete;
                ButtonText = "Send Invoice";
                DisplayInvoiceItems = "d-block";
                break;
            case JobStatus.Invoiced:
                IsInvoicedComplete = IsComplete;
                ButtonText = "Mark as Paid";
                break;
            case JobStatus.Paid:
                IsPaidComplete = IsComplete;
                break;
            default:
                break;

        }
    }

    void HandleDoorTypeChange()
    {
        Display = "d-block";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerService CustomerService { get; set; }
    }
}
#pragma warning restore 1591
