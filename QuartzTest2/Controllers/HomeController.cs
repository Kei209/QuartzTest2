using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuartzTest2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuartzTest2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly JobTest _jobTest;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _jobTest = new JobTest();
        }

        public IActionResult Index()
        {
            //_jobTest.Invoke();
            return View();
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
