using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorServerService;
using BlazorServerService.Data;
using BlazorServerService.Interfaces;
using BlazorServerService.Services;
using BlazorServerLibrary.Models;
using BlazorServerLibrary.Interfaces;
using Autofac;
using System.Runtime.Loader;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using BlazorServerLibrary.Models.Doors;
using BlazorServerLibrary.Models.Jobs;
using System.IO.Abstractions;
using Microsoft.Extensions.Azure;
using Azure.Storage.Queues;
using Azure.Storage.Blobs;
using Azure.Core.Extensions;

namespace BlazorServer_FS_Web
{
    public class Startup
    {
        public ILifetimeScope AutofacContainer { get; private set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });
            services.AddDbContext<DataContext>(options =>
                    options.UseSqlServer(Configuration["ConnectionStrings:OrbitDbServerAzure"]));

            //services.AddTransient<ICustomer, Customer>();
            //services.AddTransient<IJob, Job>();

            //services.AddTransient<IDataContext, DataContext>();
            services.AddTransient<IDoor, RollerShutterDoor>().AddOptions();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<INewInstallService<NewInstall>, NewInstallsService<NewInstall>>();
            services.AddTransient<IDoorService, DoorService>();
            services.AddTransient<IInvoiceService, InvoiceService>();
            services.AddTransient<IJobService, JobService>();
            services.AddTransient<IFileSystem, FileSystem>();
            services.AddAzureClients(builder =>
            {
                builder.AddBlobServiceClient(Configuration["ConnectionStrings:AZURE_STORAGE_CONNECTION_STRING:blob"], preferMsi: true);
                builder.AddQueueServiceClient(Configuration["ConnectionStrings:AZURE_STORAGE_CONNECTION_STRING:queue"], preferMsi: true);
            });
            services.AddAzureClients(builder =>
            {
                builder.AddBlobServiceClient(Configuration["ConnectionStrings:AZURE_STORAGE_CONNECTION_STRING:blob"], preferMsi: true);
                builder.AddQueueServiceClient(Configuration["ConnectionStrings:AZURE_STORAGE_CONNECTION_STRING:queue"], preferMsi: true);
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            // Register your own things directly with Autofac, like:
            //builder.RegisterModule(new MyApplicationModule());

            //builder.RegisterType<Address>().As<IAddress>();
            //builder.RegisterType<List<Address>>().As<ICollection<IAddress>>();
            //builder.RegisterType<Customer>().As<ICustomer>();
            //builder.Register(c => new Customer { Address = c.Resolve<List<Address>>() });
            //builder.RegisterType<RollerShutter>().As<IDoor>().InstancePerLifetimeScope();
            //builder.RegisterType<RollerShutter>().Named<IDoor>("RollerShutter").InstancePerLifetimeScope();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            this.AutofacContainer = app.ApplicationServices.GetAutofacRoot();
        }
    }
    internal static class StartupExtensions
    {
        public static IAzureClientBuilder<BlobServiceClient, BlobClientOptions> AddBlobServiceClient(this AzureClientFactoryBuilder builder, string serviceUriOrConnectionString, bool preferMsi)
        {
            if (preferMsi && Uri.TryCreate(serviceUriOrConnectionString, UriKind.Absolute, out Uri serviceUri))
            {
                return builder.AddBlobServiceClient(serviceUri);
            }
            else
            {
                return builder.AddBlobServiceClient(serviceUriOrConnectionString);
            }
        }
        public static IAzureClientBuilder<QueueServiceClient, QueueClientOptions> AddQueueServiceClient(this AzureClientFactoryBuilder builder, string serviceUriOrConnectionString, bool preferMsi)
        {
            if (preferMsi && Uri.TryCreate(serviceUriOrConnectionString, UriKind.Absolute, out Uri serviceUri))
            {
                return builder.AddQueueServiceClient(serviceUri);
            }
            else
            {
                return builder.AddQueueServiceClient(serviceUriOrConnectionString);
            }
        }
    }
}
