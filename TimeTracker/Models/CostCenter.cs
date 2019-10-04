using System;

namespace TimeTracker.Models
{
    public class CostCenter
    {
        [System.ComponentModel.DataAnnotations.Key]
        public double TimePercentage { get; set; }
        public DateTime TotalTime { get; set; }
        public int UserId { get; set; }


    }
}