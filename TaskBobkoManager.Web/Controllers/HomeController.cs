using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskBobkoManager.Web.Models;

namespace TaskBobkoManager.Web.Controllers
{
    public class HomeController : Controller
    {
        int val = 0;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
        public IActionResult SignIn()
        {
            return View("login");
        }
        public IActionResult SignUp() 
        {
            return View("Index");
        }
        public IActionResult DashboardView() 
        {
            return View("Dashboard");
        }
    }
}