using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Controllers
{
    public class LeaveTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LeaveTypeController(ApplicationDbContext context)
        {
            _context = context;
        }


        //GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            var leaveTypes = await _context.LeaveTypes.ToListAsync();
            return View(leaveTypes); // Select * From LeaveTypes
        }
        //GET : LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var leaveType = await _context.LeaveTypes.FirstOrDefaultAsync(m => m.Id == id);
            if (leaveType == null)
            {
                return NotFound();
            }
            return View(leaveType);
        }
        //GET : LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }
        //POST : LeaveTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name, DefaultDays, Id, DateCreated, DateModified")] LeaveType leaveType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leaveType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leaveType);
        }
        //GET : LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var leaveType = await _context.LeaveTypes.FirstOrDefaultAsync(m => m.Id == id);
            if (leaveType == null)
            {
                return NotFound();
            }
            return View(leaveType);
        }
        //POST : LeaveTypes/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name, DefaultDays, Id, DateCreated, DateModified")] LeaveType leaveType)
        {
            if (id != leaveType.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leaveType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveTypeExists(leaveType.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveType);
        }
        //GET : LeaveType:Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var leaveType = await _context.LeaveTypes
                .FirstOrDefaultAsync(m =>m.Id == id);
            if (leaveType==null)
            {
                return NotFound();
            }
            return View(leaveType);
        }
        //POST : LeaveTypes/Create
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leaveType= await _context.LeaveTypes.FindAsync(id);
                _context.LeaveTypes.Remove(leaveType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
        }
        private bool LeaveTypeExists(int id)
        {
            return _context.LeaveTypes.Any(m => m.Id == id);
        }

    }
}
