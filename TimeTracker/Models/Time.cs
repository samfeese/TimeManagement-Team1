using System;
using System.Timers;

namespace TimeTracker.Models
{   
    public class Time
    {
        //[System.ComponentModel.DataAnnotations.Key]
        public int TimeId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int TotalTime { get; set; }

        
        public int CostCenterId { get; set; }
        public int IdentityUserId { get; set; }
    }
}