using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace TimeTracker.Models
{
    public class TimeTrackerDbContext : IdentityDbContext<IdentityUser>
    {
        public TimeTrackerDbContext(DbContextOptions<TimeTrackerDbContext> options) : base(options) { }
      
       
        public DbSet<Time> Time { get; set; }
        public DbSet<CostCenter> CostCenter { get; set; }

        
          

    }
}
