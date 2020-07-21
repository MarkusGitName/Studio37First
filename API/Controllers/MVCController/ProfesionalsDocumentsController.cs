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
    public class ProfesionalsDocumentsController : Controller
    {
        private readonly AdventureContext _context;

        public ProfesionalsDocumentsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: ProfesionalsDocuments
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.ProfesionalsDocuments.Include(p => p.User);
            return View(await adventureContext.ToListAsync());
        }

        // GET: ProfesionalsDocuments/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesionalsDocuments = await _context.ProfesionalsDocuments
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profesionalsDocuments == null)
            {
                return NotFound();
            }

            return View(profesionalsDocuments);
        }

        // GET: ProfesionalsDocuments/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.ProfesionallsProfile, "UserId", "UserId");
            return View();
        }

        // POST: ProfesionalsDocuments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,Discription,DocumentPath,VissibleToPublic,VissibleToFollowers")] ProfesionalsDocuments profesionalsDocuments)
        {
            if (ModelState.IsValid)
            {
                profesionalsDocuments.Id = Guid.NewGuid();
                _context.Add(profesionalsDocuments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.ProfesionallsProfile, "UserId", "UserId", profesionalsDocuments.UserId);
            return View(profesionalsDocuments);
        }

        // GET: ProfesionalsDocuments/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesionalsDocuments = await _context.ProfesionalsDocuments.FindAsync(id);
            if (profesionalsDocuments == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.ProfesionallsProfile, "UserId", "UserId", profesionalsDocuments.UserId);
            return View(profesionalsDocuments);
        }

        // POST: ProfesionalsDocuments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UserId,Discription,DocumentPath,VissibleToPublic,VissibleToFollowers")] ProfesionalsDocuments profesionalsDocuments)
        {
            if (id != profesionalsDocuments.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profesionalsDocuments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfesionalsDocumentsExists(profesionalsDocuments.Id))
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
            ViewData["UserId"] = new SelectList(_context.ProfesionallsProfile, "UserId", "UserId", profesionalsDocuments.UserId);
            return View(profesionalsDocuments);
        }

        // GET: ProfesionalsDocuments/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesionalsDocuments = await _context.ProfesionalsDocuments
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profesionalsDocuments == null)
            {
                return NotFound();
            }

            return View(profesionalsDocuments);
        }

        // POST: ProfesionalsDocuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var profesionalsDocuments = await _context.ProfesionalsDocuments.FindAsync(id);
            _context.ProfesionalsDocuments.Remove(profesionalsDocuments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfesionalsDocumentsExists(Guid id)
        {
            return _context.ProfesionalsDocuments.Any(e => e.Id == id);
        }
    }
}
