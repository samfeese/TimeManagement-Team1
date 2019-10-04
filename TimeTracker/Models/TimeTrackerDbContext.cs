using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace TimeTracker.Models
{
    public class TimeTrackerDbContext : DbContext
    {      

        public DbSet<Profile> Profile { get; set; }
        public DbSet<Time> Time { get; set; }
        public DbSet<CostCenter> CostCenter { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = TimeTracker; Trusted_Connection = True;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
