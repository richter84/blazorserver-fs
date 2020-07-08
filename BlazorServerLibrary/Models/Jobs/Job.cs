﻿using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Interfaces;
using BlazorServerLibrary.Models.Doors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorServerLibrary.Models.Jobs
{
    public abstract class Job
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public abstract string SerialNumber { get; set; }
        public JobStatus Status { get; set; }
        public Customer Customer { get; set; } // = new Customer();
        public abstract Door Door { get; set; }
        public Handover Handover { get; set; } = new Handover();
        public ICollection<HistoryStatus> History { get; set; } = new List<HistoryStatus>();
        public ICollection<Invoice> Invoices { get; set; }
    }
}