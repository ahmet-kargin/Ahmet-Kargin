using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UI.Models;

namespace UI.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        ColorManager cm = new ColorManager(new EfColorRepository());
        SizeManager sm = new SizeManager(new EfSizeRepository());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(int id)
        {
            if (id==0)
            {
                return View(pm.GetList());
            }
            return View(pm.GetProductByCategory(id));
        }
        public IActionResult CompanyList(int id)
        {
            if (id == 0)
            {
                return View(pm.GetList());
            }
            return View(pm.GetProductByCompany(id));
        }
        public IActionResult Detail(int id)
        {
            List<SelectListItem> colorvalues = (from x in cm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.ColorId.ToString()
                                               }).ToList();
            ViewBag.cv = colorvalues;
            List<SelectListItem> sizevalues = (from x in sm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.SizeName,
                                                    Value = x.SizeId.ToString()
                                                }).ToList();
            ViewBag.sv = sizevalues;
            return View(pm.GetProductDetail(id));
        }
        [HttpPost]
        public IActionResult CommentAdd(Comment comment)
        {
            CommentManager cm = new CommentManager(new EfCommentRepository());
            comment.CommentStatus = true;
            cm.Add(comment);
            return RedirectToAction("Detail", new {id=comment.ProductId});
        }
    }
}
