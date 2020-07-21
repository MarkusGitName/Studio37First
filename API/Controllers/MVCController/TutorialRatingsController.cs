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
    public class TutorialRatingsController : Controller
    {
        private readonly AdventureContext _context;

        public TutorialRatingsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: TutorialRatings
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.TutorialRating.Include(t => t.Tutorial).Include(t => t.User);
            return View(await adventureContext.ToListAsync());
        }

        // GET: TutorialRatings/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialRating = await _context.TutorialRating
                .Include(t => t.Tutorial)
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorialRating == null)
            {
                return NotFound();
            }

            return View(tutorialRating);
        }

        // GET: TutorialRatings/Create
        public IActionResult Create()
        {
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId");
            return View();
        }

        // POST: TutorialRatings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,TutorialId,Rating")] TutorialRating tutorialRating)
        {
            if (ModelState.IsValid)
            {
                tutorialRating.Id = Guid.NewGuid();
                _context.Add(tutorialRating);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialRating.TutorialId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", tutorialRating.UserId);
            return View(tutorialRating);
        }

        // GET: TutorialRatings/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialRating = await _context.TutorialRating.FindAsync(id);
            if (tutorialRating == null)
            {
                return NotFound();
            }
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialRating.TutorialId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", tutorialRating.UserId);
            return View(tutorialRating);
        }

        // POST: TutorialRatings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UserId,TutorialId,Rating")] TutorialRating tutorialRating)
        {
            if (id != tutorialRating.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tutorialRating);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TutorialRatingExists(tutorialRating.Id))
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
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialRating.TutorialId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", tutorialRating.UserId);
            return View(tutorialRating);
        }

        // GET: TutorialRatings/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialRating = await _context.TutorialRating
                .Include(t => t.Tutorial)
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorialRating == null)
            {
                return NotFound();
            }

            return View(tutorialRating);
        }

        // POST: TutorialRatings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tutorialRating = await _context.TutorialRating.FindAsync(id);
            _context.TutorialRating.Remove(tutorialRating);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TutorialRatingExists(Guid id)
        {
            return _context.TutorialRating.Any(e => e.Id == id);
        }
    }
}
