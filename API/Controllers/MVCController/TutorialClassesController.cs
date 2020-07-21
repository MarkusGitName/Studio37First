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
    public class TutorialClassesController : Controller
    {
        private readonly AdventureContext _context;

        public TutorialClassesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: TutorialClasses
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.TutorialClasses.Include(t => t.ClassVideo).Include(t => t.Tutorial);
            return View(await adventureContext.ToListAsync());
        }

        // GET: TutorialClasses/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialClasses = await _context.TutorialClasses
                .Include(t => t.ClassVideo)
                .Include(t => t.Tutorial)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorialClasses == null)
            {
                return NotFound();
            }

            return View(tutorialClasses);
        }

        // GET: TutorialClasses/Create
        public IActionResult Create()
        {
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id");
            ViewData["TutorialId"] = new SelectList(_context.TutorialCattegory, "Id", "Id");
            return View();
        }

        // POST: TutorialClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TutorialId,ClassVideoId")] TutorialClasses tutorialClasses)
        {
            if (ModelState.IsValid)
            {
                tutorialClasses.Id = Guid.NewGuid();
                _context.Add(tutorialClasses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id", tutorialClasses.ClassVideoId);
            ViewData["TutorialId"] = new SelectList(_context.TutorialCattegory, "Id", "Id", tutorialClasses.TutorialId);
            return View(tutorialClasses);
        }

        // GET: TutorialClasses/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialClasses = await _context.TutorialClasses.FindAsync(id);
            if (tutorialClasses == null)
            {
                return NotFound();
            }
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id", tutorialClasses.ClassVideoId);
            ViewData["TutorialId"] = new SelectList(_context.TutorialCattegory, "Id", "Id", tutorialClasses.TutorialId);
            return View(tutorialClasses);
        }

        // POST: TutorialClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,TutorialId,ClassVideoId")] TutorialClasses tutorialClasses)
        {
            if (id != tutorialClasses.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tutorialClasses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TutorialClassesExists(tutorialClasses.Id))
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
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id", tutorialClasses.ClassVideoId);
            ViewData["TutorialId"] = new SelectList(_context.TutorialCattegory, "Id", "Id", tutorialClasses.TutorialId);
            return View(tutorialClasses);
        }

        // GET: TutorialClasses/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialClasses = await _context.TutorialClasses
                .Include(t => t.ClassVideo)
                .Include(t => t.Tutorial)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorialClasses == null)
            {
                return NotFound();
            }

            return View(tutorialClasses);
        }

        // POST: TutorialClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tutorialClasses = await _context.TutorialClasses.FindAsync(id);
            _context.TutorialClasses.Remove(tutorialClasses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TutorialClassesExists(Guid id)
        {
            return _context.TutorialClasses.Any(e => e.Id == id);
        }
    }
}
