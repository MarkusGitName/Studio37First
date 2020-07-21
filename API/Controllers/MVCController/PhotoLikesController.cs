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
    public class PhotoLikesController : Controller
    {
        private readonly AdventureContext _context;

        public PhotoLikesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: PhotoLikes
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.PhotoLike.Include(p => p.Like).Include(p => p.Photo);
            return View(await adventureContext.ToListAsync());
        }

        // GET: PhotoLikes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photoLike = await _context.PhotoLike
                .Include(p => p.Like)
                .Include(p => p.Photo)
                .FirstOrDefaultAsync(m => m.PhotoId == id);
            if (photoLike == null)
            {
                return NotFound();
            }

            return View(photoLike);
        }

        // GET: PhotoLikes/Create
        public IActionResult Create()
        {
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id");
            ViewData["PhotoId"] = new SelectList(_context.Photos, "Id", "Id");
            return View();
        }

        // POST: PhotoLikes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhotoId,LikeId")] PhotoLike photoLike)
        {
            if (ModelState.IsValid)
            {
                photoLike.PhotoId = Guid.NewGuid();
                _context.Add(photoLike);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id", photoLike.LikeId);
            ViewData["PhotoId"] = new SelectList(_context.Photos, "Id", "Id", photoLike.PhotoId);
            return View(photoLike);
        }

        // GET: PhotoLikes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photoLike = await _context.PhotoLike.FindAsync(id);
            if (photoLike == null)
            {
                return NotFound();
            }
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id", photoLike.LikeId);
            ViewData["PhotoId"] = new SelectList(_context.Photos, "Id", "Id", photoLike.PhotoId);
            return View(photoLike);
        }

        // POST: PhotoLikes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("PhotoId,LikeId")] PhotoLike photoLike)
        {
            if (id != photoLike.PhotoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(photoLike);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhotoLikeExists(photoLike.PhotoId))
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
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id", photoLike.LikeId);
            ViewData["PhotoId"] = new SelectList(_context.Photos, "Id", "Id", photoLike.PhotoId);
            return View(photoLike);
        }

        // GET: PhotoLikes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photoLike = await _context.PhotoLike
                .Include(p => p.Like)
                .Include(p => p.Photo)
                .FirstOrDefaultAsync(m => m.PhotoId == id);
            if (photoLike == null)
            {
                return NotFound();
            }

            return View(photoLike);
        }

        // POST: PhotoLikes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var photoLike = await _context.PhotoLike.FindAsync(id);
            _context.PhotoLike.Remove(photoLike);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhotoLikeExists(Guid id)
        {
            return _context.PhotoLike.Any(e => e.PhotoId == id);
        }
    }
}
