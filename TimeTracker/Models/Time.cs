using System;
using System.Timers;

namespace TimeTracker.Models
{   
    public class Time
    {
        [System.ComponentModel.DataAnnotations.Key]
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime TotalTime { get; set; }
        public int UserId { get; set; }
    }
}