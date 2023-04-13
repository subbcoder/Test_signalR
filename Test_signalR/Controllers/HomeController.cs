using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test_signalR.Models;

namespace Test_signalR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }

    }
}