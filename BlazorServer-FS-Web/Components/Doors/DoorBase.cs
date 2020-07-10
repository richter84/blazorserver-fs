using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer_FS_Web.Components.Doors
{
    public class DoorBase : ComponentBase
    {
        [Parameter]
        public bool IsVisible { get; set; }
    }
}
