using BlazorServerLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Interfaces
{
    public interface IHIstoryStatus
    {
        int Id { get; set; }
        DateTimeOffset Entry { get; set; }
        JobStatus Status { get; set; }
    }
}
