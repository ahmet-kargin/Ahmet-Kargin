using KUSYS_Project.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KUSYS_Project.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Contact()
        {
            ViewData["title"] = "Contact : ";
            return View();
        }
    }
}