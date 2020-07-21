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
    public class ClassVideoSalesController : Controller
    {
        private readonly AdventureContext _context;

        public ClassVideoSalesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: ClassVideoSales
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.ClassVideoSale.Include(c => c.ClassVideo).Include(c => c.Sale);
            return View(await adventureContext.ToListAsync());
        }

        // GET: ClassVideoSales/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classVideoSale = await _context.ClassVideoSale
                .Include(c => c.ClassVideo)
                .Include(c => c.Sale)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classVideoSale == null)
            {
                return NotFound();
            }

            return View(classVideoSale);
        }

        // GET: ClassVideoSales/Create
        public IActionResult Create()
        {
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id");
            ViewData["SaleId"] = new SelectList(_context.Sale, "Id", "BuyerId");
            return View();
        }

        // POST: ClassVideoSales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClassVideoId,SaleId,Price")] ClassVideoSale classVideoSale)
        {
            if (ModelState.IsValid)
            {
                classVideoSale.Id = Guid.NewGuid();
                _context.Add(classVideoSale);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id", classVideoSale.ClassVideoId);
            ViewData["SaleId"] = new SelectList(_context.Sale, "Id", "BuyerId", classVideoSale.SaleId);
            return View(classVideoSale);
        }

        // GET: ClassVideoSales/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classVideoSale = await _context.ClassVideoSale.FindAsync(id);
            if (classVideoSale == null)
            {
                return NotFound();
            }
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id", classVideoSale.ClassVideoId);
            ViewData["SaleId"] = new SelectList(_context.Sale, "Id", "BuyerId", classVideoSale.SaleId);
            return View(classVideoSale);
        }

        // POST: ClassVideoSales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,ClassVideoId,SaleId,Price")] ClassVideoSale classVideoSale)
        {
            if (id != classVideoSale.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classVideoSale);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassVideoSaleExists(classVideoSale.Id))
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
            ViewData["ClassVideoId"] = new SelectList(_context.ClassVideo, "Id", "Id", classVideoSale.ClassVideoId);
            ViewData["SaleId"] = new SelectList(_context.Sale, "Id", "BuyerId", classVideoSale.SaleId);
            return View(classVideoSale);
        }

        // GET: ClassVideoSales/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classVideoSale = await _context.ClassVideoSale
                .Include(c => c.ClassVideo)
                .Include(c => c.Sale)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classVideoSale == null)
            {
                return NotFound();
            }

            return View(classVideoSale);
        }

        // POST: ClassVideoSales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var classVideoSale = await _context.ClassVideoSale.FindAsync(id);
            _context.ClassVideoSale.Remove(classVideoSale);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassVideoSaleExists(Guid id)
        {
            return _context.ClassVideoSale.Any(e => e.Id == id);
        }
    }
}
