﻿// <auto-generated />
using System;
using BlazorServerService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorServerService.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200705191200_UrlSignatureHandover")]
    partial class UrlSignatureHandover
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorServerLibrary.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TownCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTimeOffset>("LastUpdated")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Doors.Door", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Colour")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoorType")
                        .HasColumnType("int");

                    b.Property<string>("ExtraNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FixingType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSupplied")
                        .HasColumnType("bit");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OpeningSizeHeight")
                        .HasColumnType("float");

                    b.Property<double>("OpeningSizeWidth")
                        .HasColumnType("float");

                    b.Property<int>("Sector")
                        .HasColumnType("int");

                    b.Property<string>("SupplierOrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Door");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Door");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.ElectricOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Control")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ElectricalSafety")
                        .HasColumnType("int");

                    b.Property<string>("MotorType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PECQty")
                        .HasColumnType("int");

                    b.Property<int>("SupplyType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ElectricOperation");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Handover", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ControlsIfApplicable")
                        .HasColumnType("bit");

                    b.Property<bool>("Demonstration")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsCompleteByEngineer")
                        .HasColumnType("bit");

                    b.Property<string>("PointOfContactName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PointOfContactSignatureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SafetyDevicesExplained")
                        .HasColumnType("bit");

                    b.Property<bool>("ServiceScheduleLog")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("StartDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Handover");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.HistoryStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Entry")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("HistoryStatus");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("InvoiceNumber")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("JobId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Jobs.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoorId")
                        .HasColumnType("int");

                    b.Property<int?>("HandoverId")
                        .HasColumnType("int");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DoorId");

                    b.HasIndex("HandoverId");

                    b.ToTable("Job");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Job");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Doors.BarsGrillesDoor", b =>
                {
                    b.HasBaseType("BlazorServerLibrary.Models.Doors.Door");

                    b.Property<double>("FH")
                        .HasColumnType("float");

                    b.Property<double>("FW")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("BarsGrillesDoor");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Doors.GatesDoor", b =>
                {
                    b.HasBaseType("BlazorServerLibrary.Models.Doors.Door");

                    b.Property<bool>("IsHingedLeaf")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHingesBottomTrack")
                        .HasColumnType("bit");

                    b.Property<int>("Leafs")
                        .HasColumnType("int");

                    b.Property<double>("OverJambSize")
                        .HasColumnType("float");

                    b.Property<double>("OverTracksSize")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("GatesDoor");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Doors.PedestrianDoor", b =>
                {
                    b.HasBaseType("BlazorServerLibrary.Models.Doors.Door");

                    b.Property<int>("ElectricalEntry")
                        .HasColumnType("int");

                    b.Property<int>("FireDefence")
                        .HasColumnType("int");

                    b.Property<string>("HandleType")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("IsCloser")
                        .HasColumnType("bit");

                    b.Property<bool>("IsElectricalEntry")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFireEscape")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMagLock")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfLockingPoints")
                        .HasColumnType("int");

                    b.Property<double>("SizeOverStandardHeight")
                        .HasColumnType("float");

                    b.Property<double>("SizeOverStandardWidth")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("PedestrianDoor");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Doors.RollerShutterDoor", b =>
                {
                    b.HasBaseType("BlazorServerLibrary.Models.Doors.Door");

                    b.Property<string>("AngleCutSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AngleType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AntiFallSafety")
                        .HasColumnType("int");

                    b.Property<string>("BGSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Canopy")
                        .HasColumnType("bit");

                    b.Property<string>("CanopyCutSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CanopyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurtainType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ElectricOperationId")
                        .HasColumnType("int");

                    b.Property<string>("FHSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Fascia")
                        .HasColumnType("bit");

                    b.Property<string>("FasciaSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FasciaType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FireDefence")
                        .HasColumnName("RollerShutterDoor_FireDefence")
                        .HasColumnType("int");

                    b.Property<string>("GuideCutSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuideType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBoltOnGuides")
                        .HasColumnType("bit");

                    b.Property<double>("LathCutSize")
                        .HasColumnType("float");

                    b.Property<int>("OperationType")
                        .HasColumnType("int");

                    b.Property<string>("RollerCutSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TubeTypeGauge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WicketEuroDoor")
                        .HasColumnType("bit");

                    b.HasIndex("ElectricOperationId");

                    b.HasDiscriminator().HasValue("RollerShutterDoor");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Doors.SectionalDoor", b =>
                {
                    b.HasBaseType("BlazorServerLibrary.Models.Doors.Door");

                    b.Property<int>("AntiFallSafety")
                        .HasColumnName("SectionalDoor_AntiFallSafety")
                        .HasColumnType("int");

                    b.Property<double>("Cable")
                        .HasColumnType("float");

                    b.Property<int?>("ElectricOperationId")
                        .HasColumnName("SectionalDoor_ElectricOperationId")
                        .HasColumnType("int");

                    b.Property<string>("LiftType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSprings")
                        .HasColumnType("int");

                    b.Property<int>("OperationType")
                        .HasColumnName("SectionalDoor_OperationType")
                        .HasColumnType("int");

                    b.Property<double>("OverJambSize")
                        .HasColumnName("SectionalDoor_OverJambSize")
                        .HasColumnType("float");

                    b.Property<double>("PanelOECSize")
                        .HasColumnType("float");

                    b.Property<double>("ShaftLength")
                        .HasColumnType("float");

                    b.Property<double>("ShaftSize")
                        .HasColumnType("float");

                    b.Property<double>("SizeToSpringAssembly")
                        .HasColumnType("float");

                    b.Property<double>("SpringLength")
                        .HasColumnType("float");

                    b.Property<double>("SpringSize")
                        .HasColumnType("float");

                    b.Property<double>("TopOfTrackSize")
                        .HasColumnType("float");

                    b.Property<bool>("WicketEuroDoor")
                        .HasColumnName("SectionalDoor_WicketEuroDoor")
                        .HasColumnType("bit");

                    b.HasIndex("ElectricOperationId");

                    b.HasDiscriminator().HasValue("SectionalDoor");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Jobs.NewInstall", b =>
                {
                    b.HasBaseType("BlazorServerLibrary.Models.Jobs.Job");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.HasDiscriminator().HasValue("NewInstall");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Jobs.Repair", b =>
                {
                    b.HasBaseType("BlazorServerLibrary.Models.Jobs.Job");

                    b.HasDiscriminator().HasValue("Repair");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Jobs.Servicing", b =>
                {
                    b.HasBaseType("BlazorServerLibrary.Models.Jobs.Job");

                    b.HasDiscriminator().HasValue("Servicing");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Address", b =>
                {
                    b.HasOne("BlazorServerLibrary.Models.Customer", null)
                        .WithMany("Address")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.HistoryStatus", b =>
                {
                    b.HasOne("BlazorServerLibrary.Models.Jobs.Job", null)
                        .WithMany("History")
                        .HasForeignKey("JobId");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Invoice", b =>
                {
                    b.HasOne("BlazorServerLibrary.Models.Jobs.Job", null)
                        .WithMany("Invoices")
                        .HasForeignKey("JobId");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Jobs.Job", b =>
                {
                    b.HasOne("BlazorServerLibrary.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("BlazorServerLibrary.Models.Doors.Door", "Door")
                        .WithMany()
                        .HasForeignKey("DoorId");

                    b.HasOne("BlazorServerLibrary.Models.Handover", "Handover")
                        .WithMany()
                        .HasForeignKey("HandoverId");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Doors.RollerShutterDoor", b =>
                {
                    b.HasOne("BlazorServerLibrary.Models.ElectricOperation", "ElectricOperation")
                        .WithMany()
                        .HasForeignKey("ElectricOperationId");
                });

            modelBuilder.Entity("BlazorServerLibrary.Models.Doors.SectionalDoor", b =>
                {
                    b.HasOne("BlazorServerLibrary.Models.ElectricOperation", "ElectricOperation")
                        .WithMany()
                        .HasForeignKey("ElectricOperationId");
                });
#pragma warning restore 612, 618
        }
    }
}
