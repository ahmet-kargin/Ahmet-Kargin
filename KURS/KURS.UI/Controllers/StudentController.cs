using KURS.DATA.Concrete;
using KURS.ENTITY;
using KUSYS_Project.Data.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KUSYS_Project.WebUI.Controllers
{
    public class StudentController : Controller
    {
        private readonly CourseDbContext _context;
        //ctor
        public StudentController(CourseDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }


        public IActionResult Details(int id)
        {
            var student = _context.Students.Find(id);
            return View(student);
        }
        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var author = _context.Students.Find(id);
            return View(author);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _context.Students.Find(id);
            _context.Students.Update(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
