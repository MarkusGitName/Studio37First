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
    public class TutorialPromoPhotoesController : Controller
    {
        private readonly AdventureContext _context;

        public TutorialPromoPhotoesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: TutorialPromoPhotoes
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.TutorialPromoPhoto.Include(t => t.PromoPhoto).Include(t => t.Tutorial);
            return View(await adventureContext.ToListAsync());
        }

        // GET: TutorialPromoPhotoes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialPromoPhoto = await _context.TutorialPromoPhoto
                .Include(t => t.PromoPhoto)
                .Include(t => t.Tutorial)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorialPromoPhoto == null)
            {
                return NotFound();
            }

            return View(tutorialPromoPhoto);
        }

        // GET: TutorialPromoPhotoes/Create
        public IActionResult Create()
        {
            ViewData["PromoPhotoId"] = new SelectList(_context.PromoPhotos, "Id", "Id");
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id");
            return View();
        }

        // POST: TutorialPromoPhotoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TutorialId,PromoPhotoId")] TutorialPromoPhoto tutorialPromoPhoto)
        {
            if (ModelState.IsValid)
            {
                tutorialPromoPhoto.Id = Guid.NewGuid();
                _context.Add(tutorialPromoPhoto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PromoPhotoId"] = new SelectList(_context.PromoPhotos, "Id", "Id", tutorialPromoPhoto.PromoPhotoId);
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialPromoPhoto.TutorialId);
            return View(tutorialPromoPhoto);
        }

        // GET: TutorialPromoPhotoes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialPromoPhoto = await _context.TutorialPromoPhoto.FindAsync(id);
            if (tutorialPromoPhoto == null)
            {
                return NotFound();
            }
            ViewData["PromoPhotoId"] = new SelectList(_context.PromoPhotos, "Id", "Id", tutorialPromoPhoto.PromoPhotoId);
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialPromoPhoto.TutorialId);
            return View(tutorialPromoPhoto);
        }

        // POST: TutorialPromoPhotoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,TutorialId,PromoPhotoId")] TutorialPromoPhoto tutorialPromoPhoto)
        {
            if (id != tutorialPromoPhoto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tutorialPromoPhoto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TutorialPromoPhotoExists(tutorialPromoPhoto.Id))
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
            ViewData["PromoPhotoId"] = new SelectList(_context.PromoPhotos, "Id", "Id", tutorialPromoPhoto.PromoPhotoId);
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialPromoPhoto.TutorialId);
            return View(tutorialPromoPhoto);
        }

        // GET: TutorialPromoPhotoes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialPromoPhoto = await _context.TutorialPromoPhoto
                .Include(t => t.PromoPhoto)
                .Include(t => t.Tutorial)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorialPromoPhoto == null)
            {
                return NotFound();
            }

            return View(tutorialPromoPhoto);
        }

        // POST: TutorialPromoPhotoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tutorialPromoPhoto = await _context.TutorialPromoPhoto.FindAsync(id);
            _context.TutorialPromoPhoto.Remove(tutorialPromoPhoto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TutorialPromoPhotoExists(Guid id)
        {
            return _context.TutorialPromoPhoto.Any(e => e.Id == id);
        }
    }
}
