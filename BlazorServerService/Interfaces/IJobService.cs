﻿using BlazorServerLibrary.Models;
using BlazorServerLibrary.Models.Jobs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerService.Interfaces
{
    public interface IJobService
    {
        Task<List<NewInstall>> GetNewInstalls();
    }
}
