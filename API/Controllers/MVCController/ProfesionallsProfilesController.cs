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
    public class ProfesionallsProfilesController : Controller
    {
        private readonly AdventureContext _context;

        public ProfesionallsProfilesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: ProfesionallsProfiles
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.ProfesionallsProfile.Include(p => p.User);
            return View(await adventureContext.ToListAsync());
        }

        // GET: ProfesionallsProfiles/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesionallsProfile = await _context.ProfesionallsProfile
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (profesionallsProfile == null)
            {
                return NotFound();
            }

            return View(profesionallsProfile);
        }

        // GET: ProfesionallsProfiles/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId");
            return View();
        }

        // POST: ProfesionallsProfiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,YearsExperience,Description,Logo,ProfesionalEmail")] ProfesionallsProfile profesionallsProfile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profesionallsProfile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", profesionallsProfile.UserId);
            return View(profesionallsProfile);
        }

        // GET: ProfesionallsProfiles/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesionallsProfile = await _context.ProfesionallsProfile.FindAsync(id);
            if (profesionallsProfile == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", profesionallsProfile.UserId);
            return View(profesionallsProfile);
        }

        // POST: ProfesionallsProfiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserId,YearsExperience,Description,Logo,ProfesionalEmail")] ProfesionallsProfile profesionallsProfile)
        {
            if (id != profesionallsProfile.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profesionallsProfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfesionallsProfileExists(profesionallsProfile.UserId))
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
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", profesionallsProfile.UserId);
            return View(profesionallsProfile);
        }

        // GET: ProfesionallsProfiles/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesionallsProfile = await _context.ProfesionallsProfile
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (profesionallsProfile == null)
            {
                return NotFound();
            }

            return View(profesionallsProfile);
        }

        // POST: ProfesionallsProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var profesionallsProfile = await _context.ProfesionallsProfile.FindAsync(id);
            _context.ProfesionallsProfile.Remove(profesionallsProfile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfesionallsProfileExists(string id)
        {
            return _context.ProfesionallsProfile.Any(e => e.UserId == id);
        }
    }
}
