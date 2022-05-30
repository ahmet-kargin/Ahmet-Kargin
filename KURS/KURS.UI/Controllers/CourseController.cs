using KURS.DATA.Concrete;
using KUSYS_Project.Data.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KUSYS_Project.WebUI.Controllers
{
    public class CourseController : Controller
    {
        private readonly CourseDbContext _context;
        public CourseController(CourseDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }
       
    }
}
