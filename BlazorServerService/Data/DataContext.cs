using BlazorServerLibrary.Models;
using BlazorServerLibrary.Models.Doors;
using BlazorServerLibrary.Models.Jobs;
using BlazorServerService.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerService.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<RollerShutterDoor> RollerShutters { get; set; }
        public DbSet<SectionalDoor> Sectionals { get; set; }
        public DbSet<PedestrianDoor> Pedestrians { get; set; }
        public DbSet<GatesDoor> Gates { get; set; }
        public DbSet<BarsGrillesDoor> BarsGrilles { get; set; }
        public DbSet<NewInstall> NewInstalls { get; set; }
        public DbSet<Servicing> Servicings { get; set; }
        public DbSet<Repair> Repair { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Job> Jobs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Address>().ToTable("Address");
            builder.Entity<Customer>().ToTable("Customer");
            builder.Entity<Door>().ToTable("Door");
            //builder.Entity<RollerShutter>().ToTable("RollerShutter");
            builder.Entity<Job>().ToTable("Job");
            builder.Entity<Invoice>().ToTable("Invoice");

            //builder.Entity<NewInstall>().ToTable("NewInstall");

            builder.Entity<Customer>().Property<DateTimeOffset>("LastUpdated");
            builder.Entity<Customer>().Property<DateTimeOffset>("Created");
            builder.Entity<NewInstall>().Property<DateTimeOffset>("Created");

            builder.Entity<Job>().HasDiscriminator<string>("Discriminator");
        }
    }
}
