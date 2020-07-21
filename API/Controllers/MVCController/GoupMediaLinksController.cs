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
    public class GoupMediaLinksController : Controller
    {
        private readonly AdventureContext _context;

        public GoupMediaLinksController(AdventureContext context)
        {
            _context = context;
        }

        // GET: GoupMediaLinks
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.GoupMediaLink.Include(g => g.Group);
            return View(await adventureContext.ToListAsync());
        }

        // GET: GoupMediaLinks/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goupMediaLink = await _context.GoupMediaLink
                .Include(g => g.Group)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goupMediaLink == null)
            {
                return NotFound();
            }

            return View(goupMediaLink);
        }

        // GET: GoupMediaLinks/Create
        public IActionResult Create()
        {
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Id");
            return View();
        }

        // POST: GoupMediaLinks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GroupId,Link")] GoupMediaLink goupMediaLink)
        {
            if (ModelState.IsValid)
            {
                goupMediaLink.Id = Guid.NewGuid();
                _context.Add(goupMediaLink);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Id", goupMediaLink.GroupId);
            return View(goupMediaLink);
        }

        // GET: GoupMediaLinks/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goupMediaLink = await _context.GoupMediaLink.FindAsync(id);
            if (goupMediaLink == null)
            {
                return NotFound();
            }
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Id", goupMediaLink.GroupId);
            return View(goupMediaLink);
        }

        // POST: GoupMediaLinks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,GroupId,Link")] GoupMediaLink goupMediaLink)
        {
            if (id != goupMediaLink.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goupMediaLink);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoupMediaLinkExists(goupMediaLink.Id))
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
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Id", goupMediaLink.GroupId);
            return View(goupMediaLink);
        }

        // GET: GoupMediaLinks/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goupMediaLink = await _context.GoupMediaLink
                .Include(g => g.Group)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goupMediaLink == null)
            {
                return NotFound();
            }

            return View(goupMediaLink);
        }

        // POST: GoupMediaLinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var goupMediaLink = await _context.GoupMediaLink.FindAsync(id);
            _context.GoupMediaLink.Remove(goupMediaLink);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoupMediaLinkExists(Guid id)
        {
            return _context.GoupMediaLink.Any(e => e.Id == id);
        }
    }
}
