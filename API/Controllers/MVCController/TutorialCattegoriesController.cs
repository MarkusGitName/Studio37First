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
    public class TutorialCattegoriesController : Controller
    {
        private readonly AdventureContext _context;

        public TutorialCattegoriesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: TutorialCattegories
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.TutorialCattegory.Include(t => t.Cattegory).Include(t => t.Tutorial);
            return View(await adventureContext.ToListAsync());
        }

        // GET: TutorialCattegories/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialCattegory = await _context.TutorialCattegory
                .Include(t => t.Cattegory)
                .Include(t => t.Tutorial)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorialCattegory == null)
            {
                return NotFound();
            }

            return View(tutorialCattegory);
        }

        // GET: TutorialCattegories/Create
        public IActionResult Create()
        {
            ViewData["CattegoryId"] = new SelectList(_context.Categories, "Id", "Id");
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id");
            return View();
        }

        // POST: TutorialCattegories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TutorialId,CattegoryId")] TutorialCattegory tutorialCattegory)
        {
            if (ModelState.IsValid)
            {
                tutorialCattegory.Id = Guid.NewGuid();
                _context.Add(tutorialCattegory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CattegoryId"] = new SelectList(_context.Categories, "Id", "Id", tutorialCattegory.CattegoryId);
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialCattegory.TutorialId);
            return View(tutorialCattegory);
        }

        // GET: TutorialCattegories/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialCattegory = await _context.TutorialCattegory.FindAsync(id);
            if (tutorialCattegory == null)
            {
                return NotFound();
            }
            ViewData["CattegoryId"] = new SelectList(_context.Categories, "Id", "Id", tutorialCattegory.CattegoryId);
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialCattegory.TutorialId);
            return View(tutorialCattegory);
        }

        // POST: TutorialCattegories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,TutorialId,CattegoryId")] TutorialCattegory tutorialCattegory)
        {
            if (id != tutorialCattegory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tutorialCattegory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TutorialCattegoryExists(tutorialCattegory.Id))
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
            ViewData["CattegoryId"] = new SelectList(_context.Categories, "Id", "Id", tutorialCattegory.CattegoryId);
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialCattegory.TutorialId);
            return View(tutorialCattegory);
        }

        // GET: TutorialCattegories/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialCattegory = await _context.TutorialCattegory
                .Include(t => t.Cattegory)
                .Include(t => t.Tutorial)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorialCattegory == null)
            {
                return NotFound();
            }

            return View(tutorialCattegory);
        }

        // POST: TutorialCattegories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tutorialCattegory = await _context.TutorialCattegory.FindAsync(id);
            _context.TutorialCattegory.Remove(tutorialCattegory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TutorialCattegoryExists(Guid id)
        {
            return _context.TutorialCattegory.Any(e => e.Id == id);
        }
    }
}
