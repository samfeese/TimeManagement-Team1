using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TimeTracker.Models;

[assembly: HostingStartup(typeof(TimeTracker.Areas.Identity.IdentityHostingStartup))]
namespace TimeTracker.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TimeTrackerIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TimeTrackerIdentityContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<TimeTrackerIdentityContext>();
            });
        }
    }
}