using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UI.Controllers
{
    public class AdminController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        CompanyManager com = new CompanyManager(new EfCompanyRepository());
        ColorManager color = new ColorManager(new EfColorRepository());
        SizeManager sm = new SizeManager(new EfSizeRepository());
        public IActionResult Index()
        {
            return View(pm.GetProductDetailWithAll());
        }
        [HttpGet]
        public IActionResult ProductCreate()
        {
            List<SelectListItem> colorvalues = (from x in color.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.Name,
                                                    Value = x.ColorId.ToString()
                                                }).ToList();
            ViewBag.color = colorvalues;
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            List<SelectListItem> companyValues = (from x in com.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Name,
                                                      Value = x.CompanyId.ToString()
                                                  }).ToList();
            ViewBag.com = companyValues;
            ViewBag.Sizes = sm.GetList();

            return View();
        }
        [HttpPost]
        public IActionResult ProductCreate(Product p, IFormFile file, int[] sizeIds)
        {
            JobManager jobManager = new JobManager();
            p.ImageUrl = jobManager.UploadImage(file);
            var product = new Product()
            {
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                CompanyId = p.CompanyId,
                CategoryId = p.CategoryId,
                ColorId = p.ColorId,
                Status = true,
                ImageUrl=p.ImageUrl
            };
            pm.Create(product, sizeIds);
            return RedirectToAction("Index");
        }
    }
}
