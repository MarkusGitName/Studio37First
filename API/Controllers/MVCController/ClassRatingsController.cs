using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using API.Model;

namespace API.Controllers.MVCController
{
    public class ClassRatingsController : Controller
    {
        private readonly AdventureContext _context;

        public ClassRatingsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: ClassRatings
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.ClassRatings.Include(c => c.ClassVideo).Include(c => c.User);
            return View(await adventureContext.ToListAsync());
        }

        // GET: ClassRatings/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classRatings = await _context.ClassRatings
                .Include(c => c.ClassVideo)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classRatings == null)
            {
                return NotFound();
            }

            return View(classRatings);
        }

        // GET: ClassRatings/Create
        public IActionResult Create()
        {
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId");
            return View();
        }

        // POST: ClassRatings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,ClassVideoId,Rating")] ClassRatings classRatings)
        {
            if (ModelState.IsValid)
            {
                classRatings.Id = Guid.NewGuid();
                _context.Add(classRatings);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id", classRatings.ClassVideoId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", classRatings.UserId);
            return View(classRatings);
        }

        // GET: ClassRatings/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classRatings = await _context.ClassRatings.FindAsync(id);
            if (classRatings == null)
            {
                return NotFound();
            }
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id", classRatings.ClassVideoId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", classRatings.UserId);
            return View(classRatings);
        }

        // POST: ClassRatings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UserId,ClassVideoId,Rating")] ClassRatings classRatings)
        {
            if (id != classRatings.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classRatings);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassRatingsExists(classRatings.Id))
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
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id", classRatings.ClassVideoId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", classRatings.UserId);
            return View(classRatings);
        }

        // GET: ClassRatings/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classRatings = await _context.ClassRatings
                .Include(c => c.ClassVideo)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classRatings == null)
            {
                return NotFound();
            }

            return View(classRatings);
        }

        // POST: ClassRatings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var classRatings = await _context.ClassRatings.FindAsync(id);
            _context.ClassRatings.Remove(classRatings);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassRatingsExists(Guid id)
        {
            return _context.ClassRatings.Any(e => e.Id == id);
        }
    }
}
