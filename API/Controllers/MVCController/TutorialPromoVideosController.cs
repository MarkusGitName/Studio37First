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
    public class TutorialPromoVideosController : Controller
    {
        private readonly AdventureContext _context;

        public TutorialPromoVideosController(AdventureContext context)
        {
            _context = context;
        }

        // GET: TutorialPromoVideos
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.TutorialPromoVideo.Include(t => t.PromoVideo).Include(t => t.Tutorial);
            return View(await adventureContext.ToListAsync());
        }

        // GET: TutorialPromoVideos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialPromoVideo = await _context.TutorialPromoVideo
                .Include(t => t.PromoVideo)
                .Include(t => t.Tutorial)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorialPromoVideo == null)
            {
                return NotFound();
            }

            return View(tutorialPromoVideo);
        }

        // GET: TutorialPromoVideos/Create
        public IActionResult Create()
        {
            ViewData["PromoVideoId"] = new SelectList(_context.PromoVideos, "Id", "Id");
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id");
            return View();
        }

        // POST: TutorialPromoVideos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TutorialId,PromoVideoId")] TutorialPromoVideo tutorialPromoVideo)
        {
            if (ModelState.IsValid)
            {
                tutorialPromoVideo.Id = Guid.NewGuid();
                _context.Add(tutorialPromoVideo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PromoVideoId"] = new SelectList(_context.PromoVideos, "Id", "Id", tutorialPromoVideo.PromoVideoId);
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialPromoVideo.TutorialId);
            return View(tutorialPromoVideo);
        }

        // GET: TutorialPromoVideos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialPromoVideo = await _context.TutorialPromoVideo.FindAsync(id);
            if (tutorialPromoVideo == null)
            {
                return NotFound();
            }
            ViewData["PromoVideoId"] = new SelectList(_context.PromoVideos, "Id", "Id", tutorialPromoVideo.PromoVideoId);
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialPromoVideo.TutorialId);
            return View(tutorialPromoVideo);
        }

        // POST: TutorialPromoVideos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,TutorialId,PromoVideoId")] TutorialPromoVideo tutorialPromoVideo)
        {
            if (id != tutorialPromoVideo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tutorialPromoVideo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TutorialPromoVideoExists(tutorialPromoVideo.Id))
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
            ViewData["PromoVideoId"] = new SelectList(_context.PromoVideos, "Id", "Id", tutorialPromoVideo.PromoVideoId);
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialPromoVideo.TutorialId);
            return View(tutorialPromoVideo);
        }

        // GET: TutorialPromoVideos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialPromoVideo = await _context.TutorialPromoVideo
                .Include(t => t.PromoVideo)
                .Include(t => t.Tutorial)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorialPromoVideo == null)
            {
                return NotFound();
            }

            return View(tutorialPromoVideo);
        }

        // POST: TutorialPromoVideos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tutorialPromoVideo = await _context.TutorialPromoVideo.FindAsync(id);
            _context.TutorialPromoVideo.Remove(tutorialPromoVideo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TutorialPromoVideoExists(Guid id)
        {
            return _context.TutorialPromoVideo.Any(e => e.Id == id);
        }
    }
}
