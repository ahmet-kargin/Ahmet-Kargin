using KURS.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KURS.UI.Controllers
{
    public class HomeController : Controller
    {
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