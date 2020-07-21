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
    public class PromoVideosController : Controller
    {
        private readonly AdventureContext _context;

        public PromoVideosController(AdventureContext context)
        {
            _context = context;
        }

        // GET: PromoVideos
        public async Task<IActionResult> Index()
        {
            return View(await _context.PromoVideos.ToListAsync());
        }

        // GET: PromoVideos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promoVideos = await _context.PromoVideos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (promoVideos == null)
            {
                return NotFound();
            }

            return View(promoVideos);
        }

        // GET: PromoVideos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PromoVideos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VideoPath")] PromoVideos promoVideos)
        {
            if (ModelState.IsValid)
            {
                promoVideos.Id = Guid.NewGuid();
                _context.Add(promoVideos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(promoVideos);
        }

        // GET: PromoVideos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promoVideos = await _context.PromoVideos.FindAsync(id);
            if (promoVideos == null)
            {
                return NotFound();
            }
            return View(promoVideos);
        }

        // POST: PromoVideos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,VideoPath")] PromoVideos promoVideos)
        {
            if (id != promoVideos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(promoVideos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PromoVideosExists(promoVideos.Id))
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
            return View(promoVideos);
        }

        // GET: PromoVideos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promoVideos = await _context.PromoVideos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (promoVideos == null)
            {
                return NotFound();
            }

            return View(promoVideos);
        }

        // POST: PromoVideos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var promoVideos = await _context.PromoVideos.FindAsync(id);
            _context.PromoVideos.Remove(promoVideos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PromoVideosExists(Guid id)
        {
            return _context.PromoVideos.Any(e => e.Id == id);
        }
    }
}
