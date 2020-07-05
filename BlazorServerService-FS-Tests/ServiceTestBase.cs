using BlazorServerLibrary.Models;
using BlazorServerLibrary.Models.Doors;
using BlazorServerLibrary.Models.Jobs;
using BlazorServerService.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorServerService_FS_Tests
{
    public abstract class ServiceTestBase
    {
        protected DbContextOptions<DataContext> ContextOptions { get; }
        public ServiceTestBase(DbContextOptions<DataContext> contextOptions)
        {
            ContextOptions = contextOptions;
            Seed();
        }
        private void Seed()
        {
            using var context = new DataContext(ContextOptions);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var addresses = new Address[]
            {
                    new Address {
                        Street = "123 Street",
                        TownCity = "Town",
                        Region = "Region",
                        PostCode = "AA1 1AA"
                    },
                    new Address {
                        Street = "456 Street",
                        TownCity = "City",
                        Region = "Region",
                        PostCode = "BB1 1BB"
                    },

            };

            context.Addresses.AddRange(addresses);

            var customers = new Customer[]
            {
                    new Customer {
                        Name = "Customer One",
                        EmailAddress = "aaa@example.com",
                        PhoneNumber = "070000000001",
                        Address = addresses.ToList()
                    },
                    new Customer {
                        Name = "Customer Two",
                        EmailAddress = "bbb@example.com",
                        PhoneNumber = "070000000002"
                    },
                    new Customer {
                        Name = "Custoemr Three",
                        EmailAddress = "ccc@example.com",
                        PhoneNumber = "070000000003"
                    },
            };

            context.Customers.AddRange(customers);

            var newInstalls = new NewInstall()
            {
                Customer = customers.FirstOrDefault(),
                Door = new RollerShutterDoor()
                {
                    ElectricOperation = new ElectricOperation()
                }
            };

            context.NewInstalls.AddRange(newInstalls);
            context.SaveChanges();
        }
    }
}
