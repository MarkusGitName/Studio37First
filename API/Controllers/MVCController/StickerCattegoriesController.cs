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
    public class StickerCattegoriesController : Controller
    {
        private readonly AdventureContext _context;

        public StickerCattegoriesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: StickerCattegories
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.StickerCattegory.Include(s => s.Category).Include(s => s.Sticke);
            return View(await adventureContext.ToListAsync());
        }

        // GET: StickerCattegories/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stickerCattegory = await _context.StickerCattegory
                .Include(s => s.Category)
                .Include(s => s.Sticke)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stickerCattegory == null)
            {
                return NotFound();
            }

            return View(stickerCattegory);
        }

        // GET: StickerCattegories/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id");
            ViewData["StickeId"] = new SelectList(_context.Stickers, "Id", "UserId");
            return View();
        }

        // POST: StickerCattegories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StickeId,CategoryId")] StickerCattegory stickerCattegory)
        {
            if (ModelState.IsValid)
            {
                stickerCattegory.Id = Guid.NewGuid();
                _context.Add(stickerCattegory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", stickerCattegory.CategoryId);
            ViewData["StickeId"] = new SelectList(_context.Stickers, "Id", "UserId", stickerCattegory.StickeId);
            return View(stickerCattegory);
        }

        // GET: StickerCattegories/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stickerCattegory = await _context.StickerCattegory.FindAsync(id);
            if (stickerCattegory == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", stickerCattegory.CategoryId);
            ViewData["StickeId"] = new SelectList(_context.Stickers, "Id", "UserId", stickerCattegory.StickeId);
            return View(stickerCattegory);
        }

        // POST: StickerCattegories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,StickeId,CategoryId")] StickerCattegory stickerCattegory)
        {
            if (id != stickerCattegory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stickerCattegory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StickerCattegoryExists(stickerCattegory.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", stickerCattegory.CategoryId);
            ViewData["StickeId"] = new SelectList(_context.Stickers, "Id", "UserId", stickerCattegory.StickeId);
            return View(stickerCattegory);
        }

        // GET: StickerCattegories/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stickerCattegory = await _context.StickerCattegory
                .Include(s => s.Category)
                .Include(s => s.Sticke)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stickerCattegory == null)
            {
                return NotFound();
            }

            return View(stickerCattegory);
        }

        // POST: StickerCattegories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var stickerCattegory = await _context.StickerCattegory.FindAsync(id);
            _context.StickerCattegory.Remove(stickerCattegory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StickerCattegoryExists(Guid id)
        {
            return _context.StickerCattegory.Any(e => e.Id == id);
        }
    }
}
