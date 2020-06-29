using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Interfaces
{
    interface IAddress
    {
        string Street { get; set; }
        string TownCity { get; set; }
        string Region { get; set; }
        string PostCode { get; set; }
    }
}
