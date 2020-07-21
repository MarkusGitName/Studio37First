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
    public class PromoPhotosController : Controller
    {
        private readonly AdventureContext _context;

        public PromoPhotosController(AdventureContext context)
        {
            _context = context;
        }

        // GET: PromoPhotos
        public async Task<IActionResult> Index()
        {
            return View(await _context.PromoPhotos.ToListAsync());
        }

        // GET: PromoPhotos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promoPhotos = await _context.PromoPhotos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (promoPhotos == null)
            {
                return NotFound();
            }

            return View(promoPhotos);
        }

        // GET: PromoPhotos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PromoPhotos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PhotoPath")] PromoPhotos promoPhotos)
        {
            if (ModelState.IsValid)
            {
                promoPhotos.Id = Guid.NewGuid();
                _context.Add(promoPhotos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(promoPhotos);
        }

        // GET: PromoPhotos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promoPhotos = await _context.PromoPhotos.FindAsync(id);
            if (promoPhotos == null)
            {
                return NotFound();
            }
            return View(promoPhotos);
        }

        // POST: PromoPhotos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,PhotoPath")] PromoPhotos promoPhotos)
        {
            if (id != promoPhotos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(promoPhotos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PromoPhotosExists(promoPhotos.Id))
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
            return View(promoPhotos);
        }

        // GET: PromoPhotos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promoPhotos = await _context.PromoPhotos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (promoPhotos == null)
            {
                return NotFound();
            }

            return View(promoPhotos);
        }

        // POST: PromoPhotos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var promoPhotos = await _context.PromoPhotos.FindAsync(id);
            _context.PromoPhotos.Remove(promoPhotos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PromoPhotosExists(Guid id)
        {
            return _context.PromoPhotos.Any(e => e.Id == id);
        }
    }
}
