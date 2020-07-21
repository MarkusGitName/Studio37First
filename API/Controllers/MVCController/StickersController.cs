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
    public class StickersController : Controller
    {
        private readonly AdventureContext _context;

        public StickersController(AdventureContext context)
        {
            _context = context;
        }

        // GET: Stickers
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.Stickers.Include(s => s.User);
            return View(await adventureContext.ToListAsync());
        }

        // GET: Stickers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stickers = await _context.Stickers
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stickers == null)
            {
                return NotFound();
            }

            return View(stickers);
        }

        // GET: Stickers/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.ProfesionallsProfile, "UserId", "UserId");
            return View();
        }

        // POST: Stickers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,Grade")] Stickers stickers)
        {
            if (ModelState.IsValid)
            {
                stickers.Id = Guid.NewGuid();
                _context.Add(stickers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.ProfesionallsProfile, "UserId", "UserId", stickers.UserId);
            return View(stickers);
        }

        // GET: Stickers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stickers = await _context.Stickers.FindAsync(id);
            if (stickers == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.ProfesionallsProfile, "UserId", "UserId", stickers.UserId);
            return View(stickers);
        }

        // POST: Stickers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UserId,Grade")] Stickers stickers)
        {
            if (id != stickers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stickers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StickersExists(stickers.Id))
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
            ViewData["UserId"] = new SelectList(_context.ProfesionallsProfile, "UserId", "UserId", stickers.UserId);
            return View(stickers);
        }

        // GET: Stickers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stickers = await _context.Stickers
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stickers == null)
            {
                return NotFound();
            }

            return View(stickers);
        }

        // POST: Stickers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var stickers = await _context.Stickers.FindAsync(id);
            _context.Stickers.Remove(stickers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StickersExists(Guid id)
        {
            return _context.Stickers.Any(e => e.Id == id);
        }
    }
}
