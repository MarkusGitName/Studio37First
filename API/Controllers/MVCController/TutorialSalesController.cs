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
    public class TutorialSalesController : Controller
    {
        private readonly AdventureContext _context;

        public TutorialSalesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: TutorialSales
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.TutorialSale.Include(t => t.Sale).Include(t => t.Tutorial);
            return View(await adventureContext.ToListAsync());
        }

        // GET: TutorialSales/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialSale = await _context.TutorialSale
                .Include(t => t.Sale)
                .Include(t => t.Tutorial)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorialSale == null)
            {
                return NotFound();
            }

            return View(tutorialSale);
        }

        // GET: TutorialSales/Create
        public IActionResult Create()
        {
            ViewData["SaleId"] = new SelectList(_context.Sale, "Id", "BuyerId");
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id");
            return View();
        }

        // POST: TutorialSales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TutorialId,SaleId,Price,DateOfSale,Credits")] TutorialSale tutorialSale)
        {
            if (ModelState.IsValid)
            {
                tutorialSale.Id = Guid.NewGuid();
                _context.Add(tutorialSale);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SaleId"] = new SelectList(_context.Sale, "Id", "BuyerId", tutorialSale.SaleId);
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialSale.TutorialId);
            return View(tutorialSale);
        }

        // GET: TutorialSales/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialSale = await _context.TutorialSale.FindAsync(id);
            if (tutorialSale == null)
            {
                return NotFound();
            }
            ViewData["SaleId"] = new SelectList(_context.Sale, "Id", "BuyerId", tutorialSale.SaleId);
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialSale.TutorialId);
            return View(tutorialSale);
        }

        // POST: TutorialSales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,TutorialId,SaleId,Price,DateOfSale,Credits")] TutorialSale tutorialSale)
        {
            if (id != tutorialSale.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tutorialSale);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TutorialSaleExists(tutorialSale.Id))
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
            ViewData["SaleId"] = new SelectList(_context.Sale, "Id", "BuyerId", tutorialSale.SaleId);
            ViewData["TutorialId"] = new SelectList(_context.Tutorial, "Id", "Id", tutorialSale.TutorialId);
            return View(tutorialSale);
        }

        // GET: TutorialSales/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialSale = await _context.TutorialSale
                .Include(t => t.Sale)
                .Include(t => t.Tutorial)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorialSale == null)
            {
                return NotFound();
            }

            return View(tutorialSale);
        }

        // POST: TutorialSales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tutorialSale = await _context.TutorialSale.FindAsync(id);
            _context.TutorialSale.Remove(tutorialSale);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TutorialSaleExists(Guid id)
        {
            return _context.TutorialSale.Any(e => e.Id == id);
        }
    }
}
