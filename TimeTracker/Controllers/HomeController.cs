using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TimeTracker.Models;

namespace TimeTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        bool started = false;

        bool ended = false;

        static Stopwatch stopwatch = new Stopwatch();

        static string stopwatchString;

        static string[] stopwatchList;

        double currentTotal;

        double total;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Start()
        {
            stopwatch.Start();
            ViewBag.Start = true;
            started = true;
            ViewBag.End = false;
            ended = false;
            return View("Index");
        }

        public IActionResult End()
        {
            if (started || ended == false && started == false)
            {
                stopwatch.Stop();
                stopwatchString = stopwatch.Elapsed.ToString();
                stopwatchList = stopwatchString.Split(":");
                var trimIndex = stopwatchList[2].IndexOf(".");
                var hours = Convert.ToInt32(stopwatchList[1]);
                var minutes = Convert.ToInt32(stopwatchList[2].Remove(trimIndex - 1, stopwatchList[2].Length));
                if(Convert.ToInt32(stopwatchList[1]) > 0)
                {
                    currentTotal = Convert.ToInt32(stopwatchList[1])* 60 + Convert.ToInt32(stopwatchList[2]);
                }
                else if (Convert.ToInt32(stopwatchList[2].Remove(trimIndex, stopwatchList.Length)) < 5)
                {
                    currentTotal = 5;
                }
                else
                {
                    currentTotal = Convert.ToInt32(stopwatchList[2]);
                }
                ViewBag.Current = currentTotal;
                this.total += currentTotal;
                ViewBag.Total = total;
            }
            ViewBag.Start = false;
            started = false;
            ViewBag.End = true;
            ended = true;
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
