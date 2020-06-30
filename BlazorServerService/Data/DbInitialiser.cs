using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorServerService.Data
{
    public static class DbInitialiser
    {
        public static void Initialise(DataContext context)
        {
            //context.Database.EnsureCreated();
            if (context.Database.GetPendingMigrations().Any())
            {
                //https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/migrations?view=aspnetcore-3.1&tabs=visual-studio#applying-migrations-in-production
                context.Database.Migrate();
            }
        }
    }
}
