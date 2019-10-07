using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace TimeTracker.Models
{
    /// <summary>
    /// Reason that mapping didn't occur for IdentityUserId in Time Model is because we need to create our own ApplicationUser that inherits from IdentityUser and map
    /// those values there instead.
    /// </summary>
    public class TimeTrackerDbContext : IdentityDbContext<IdentityUser>
    {
        public TimeTrackerDbContext(DbContextOptions<TimeTrackerDbContext> options) : base(options) { }
      
       
        public DbSet<Time> Time { get; set; }
        public DbSet<CostCenter> CostCenter { get; set; }

        
          

    }
}
