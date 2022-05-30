using KURS.BUSSINESS.Concrete;
using KURS.DATA.Concrete;
using KUSYS_Project.Data.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KURS.UI.Controllers
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
            if (courses == null)
            {
                courses = new List<ENTITY.Course>();
           

            
            }
            return View(courses);
        }
       
    }
}
