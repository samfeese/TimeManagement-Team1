using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models
{
    public class TimeTracking
    {
        bool started = false;

        bool ended = false;

        static Stopwatch stopwatch = new Stopwatch();

        static DateTime startTime;

        static DateTime endTime;

        static string stopwatchString;

        static string[] stopwatchList;

        double currentTotal;

        double total;

        public (DateTime, bool, bool) Start()
        {
            stopwatch.Start();
            startTime = DateTime.Now;
            started = true;
            ended = false;
            return (startTime, started, ended);
        }

        public (DateTime, DateTime, bool, bool, double, double) End()
        {

            if (started || ended == false && started == false)
            {
                stopwatch.Stop();

                endTime = DateTime.Now;
                var totalTime = stopwatch.Elapsed;
                stopwatchString = stopwatch.Elapsed.ToString();
                stopwatchList = stopwatchString.Split(":");
                var trimIndex = stopwatchList[2].IndexOf(".");
                var hours = Convert.ToInt32(stopwatchList[1]);
                var minutes = Convert.ToInt32(stopwatchList[2].Remove(trimIndex - 1, stopwatchList[2].Length - 1));


                if (hours > 0)
                {
                    currentTotal = Convert.ToInt32(hours) * 60 + Convert.ToInt32(minutes);
                }
                else if (minutes < 5)
                {
                    currentTotal = 5;
                }
                else
                {
                    currentTotal = Convert.ToInt32(stopwatchList[2]);
                }
                this.total += currentTotal;
                started = false;
                ended = false;
                stopwatch.Reset();
                return (startTime, endTime, started, ended, currentTotal, total);
            }
            else
            {
                throw new Exception("Invalid time function");
            }
        }
    }
}
