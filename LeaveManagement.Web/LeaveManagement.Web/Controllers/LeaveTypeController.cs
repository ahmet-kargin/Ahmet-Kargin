using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LeaveManagement.Web.Controllers
{
    public class LeaveTypeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public LeaveTypeController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        //GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            var leaveTypes = _mapper.Map<List<LeaveTypeVM>>(await _context.LeaveTypes.ToListAsync());
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
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType = _mapper.Map<LeaveType>(leaveTypeVM);
                _context.Add(leaveTypeVM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
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
        public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType = _mapper.Map<LeaveType>(leaveTypeVM);
                    _context.Update(leaveTypeVM);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveTypeExists(leaveTypeVM.Id))
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
            return View(leaveTypeVM);
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
