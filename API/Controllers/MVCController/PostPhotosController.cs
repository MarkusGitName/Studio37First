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
    public class PostPhotosController : Controller
    {
        private readonly AdventureContext _context;

        public PostPhotosController(AdventureContext context)
        {
            _context = context;
        }

        // GET: PostPhotos
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.PostPhotos.Include(p => p.Photo).Include(p => p.Post);
            return View(await adventureContext.ToListAsync());
        }

        // GET: PostPhotos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postPhotos = await _context.PostPhotos
                .Include(p => p.Photo)
                .Include(p => p.Post)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postPhotos == null)
            {
                return NotFound();
            }

            return View(postPhotos);
        }

        // GET: PostPhotos/Create
        public IActionResult Create()
        {
            ViewData["PhotoId"] = new SelectList(_context.Photos, "Id", "Id");
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id");
            return View();
        }

        // POST: PostPhotos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PostId,PhotoId")] PostPhotos postPhotos)
        {
            if (ModelState.IsValid)
            {
                postPhotos.Id = Guid.NewGuid();
                _context.Add(postPhotos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PhotoId"] = new SelectList(_context.Photos, "Id", "Id", postPhotos.PhotoId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postPhotos.PostId);
            return View(postPhotos);
        }

        // GET: PostPhotos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postPhotos = await _context.PostPhotos.FindAsync(id);
            if (postPhotos == null)
            {
                return NotFound();
            }
            ViewData["PhotoId"] = new SelectList(_context.Photos, "Id", "Id", postPhotos.PhotoId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postPhotos.PostId);
            return View(postPhotos);
        }

        // POST: PostPhotos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,PostId,PhotoId")] PostPhotos postPhotos)
        {
            if (id != postPhotos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postPhotos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostPhotosExists(postPhotos.Id))
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
            ViewData["PhotoId"] = new SelectList(_context.Photos, "Id", "Id", postPhotos.PhotoId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postPhotos.PostId);
            return View(postPhotos);
        }

        // GET: PostPhotos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postPhotos = await _context.PostPhotos
                .Include(p => p.Photo)
                .Include(p => p.Post)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postPhotos == null)
            {
                return NotFound();
            }

            return View(postPhotos);
        }

        // POST: PostPhotos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var postPhotos = await _context.PostPhotos.FindAsync(id);
            _context.PostPhotos.Remove(postPhotos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostPhotosExists(Guid id)
        {
            return _context.PostPhotos.Any(e => e.Id == id);
        }
    }
}
