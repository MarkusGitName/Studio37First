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
    public class ClassVideoCattegoriesController : Controller
    {
        private readonly AdventureContext _context;

        public ClassVideoCattegoriesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: ClassVideoCattegories
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.ClassVideoCattegory.Include(c => c.Cattegory).Include(c => c.ClassVideo);
            return View(await adventureContext.ToListAsync());
        }

        // GET: ClassVideoCattegories/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classVideoCattegory = await _context.ClassVideoCattegory
                .Include(c => c.Cattegory)
                .Include(c => c.ClassVideo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classVideoCattegory == null)
            {
                return NotFound();
            }

            return View(classVideoCattegory);
        }

        // GET: ClassVideoCattegories/Create
        public IActionResult Create()
        {
            ViewData["CattegoryId"] = new SelectList(_context.Categories, "Id", "Id");
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id");
            return View();
        }

        // POST: ClassVideoCattegories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClassVideoId,CattegoryId,Id")] ClassVideoCattegory classVideoCattegory)
        {
            if (ModelState.IsValid)
            {
                classVideoCattegory.Id = Guid.NewGuid();
                _context.Add(classVideoCattegory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CattegoryId"] = new SelectList(_context.Categories, "Id", "Id", classVideoCattegory.CattegoryId);
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id", classVideoCattegory.ClassVideoId);
            return View(classVideoCattegory);
        }

        // GET: ClassVideoCattegories/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classVideoCattegory = await _context.ClassVideoCattegory.FindAsync(id);
            if (classVideoCattegory == null)
            {
                return NotFound();
            }
            ViewData["CattegoryId"] = new SelectList(_context.Categories, "Id", "Id", classVideoCattegory.CattegoryId);
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id", classVideoCattegory.ClassVideoId);
            return View(classVideoCattegory);
        }

        // POST: ClassVideoCattegories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ClassVideoId,CattegoryId,Id")] ClassVideoCattegory classVideoCattegory)
        {
            if (id != classVideoCattegory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classVideoCattegory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassVideoCattegoryExists(classVideoCattegory.Id))
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
            ViewData["CattegoryId"] = new SelectList(_context.Categories, "Id", "Id", classVideoCattegory.CattegoryId);
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id", classVideoCattegory.ClassVideoId);
            return View(classVideoCattegory);
        }

        // GET: ClassVideoCattegories/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classVideoCattegory = await _context.ClassVideoCattegory
                .Include(c => c.Cattegory)
                .Include(c => c.ClassVideo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classVideoCattegory == null)
            {
                return NotFound();
            }

            return View(classVideoCattegory);
        }

        // POST: ClassVideoCattegories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var classVideoCattegory = await _context.ClassVideoCattegory.FindAsync(id);
            _context.ClassVideoCattegory.Remove(classVideoCattegory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassVideoCattegoryExists(Guid id)
        {
            return _context.ClassVideoCattegory.Any(e => e.Id == id);
        }
    }
}
