using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public class HistoryStatus : IHIstoryStatus
    {
        public int Id { get; set; }
        public DateTimeOffset Entry { get; set; }
        public JobStatus Status { get; set; }
    }
}
