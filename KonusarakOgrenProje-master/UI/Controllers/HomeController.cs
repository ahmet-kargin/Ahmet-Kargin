using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
      
        public IActionResult Index()
        {
            return View(pm.GetList());
        }
    }
}