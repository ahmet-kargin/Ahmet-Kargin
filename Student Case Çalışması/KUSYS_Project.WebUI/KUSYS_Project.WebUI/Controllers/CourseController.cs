using KUSYS_Project.Data.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KUSYS_Project.WebUI.Controllers
{
    public class CourseController : Controller
    {
        private readonly CourseContext _context;
        public CourseController(CourseContext context)
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
