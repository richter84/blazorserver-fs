using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Enums
{
    public enum JobStatus
    {
        Pending = 1,
        Complete = 2,
        Approved = 3,
        Invoiced = 4,
        Paid = 5
    }
}
