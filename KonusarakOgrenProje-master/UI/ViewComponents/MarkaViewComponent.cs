using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents
{
    public class MarkaViewComponent : ViewComponent
    {
        CompanyManager cm = new CompanyManager(new EfCompanyRepository());
        public IViewComponentResult Invoke()
        {
            return View(cm.GetList());
        }
    }
}
