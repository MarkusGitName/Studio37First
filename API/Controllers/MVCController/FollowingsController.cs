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
    public class FollowingsController : Controller
    {
        private readonly AdventureContext _context;

        public FollowingsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: Followings
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.Followings.Include(f => f.FollowersNavigation).Include(f => f.FollowingNavigation);
            return View(await adventureContext.ToListAsync());
        }

        // GET: Followings/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var followings = await _context.Followings
                .Include(f => f.FollowersNavigation)
                .Include(f => f.FollowingNavigation)
                .FirstOrDefaultAsync(m => m.Followers == id);
            if (followings == null)
            {
                return NotFound();
            }

            return View(followings);
        }

        // GET: Followings/Create
        public IActionResult Create()
        {
            ViewData["Followers"] = new SelectList(_context.Profile, "UserId", "UserId");
            ViewData["Following"] = new SelectList(_context.Profile, "UserId", "UserId");
            return View();
        }

        // POST: Followings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Followers,Following")] Followings followings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(followings);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Followers"] = new SelectList(_context.Profile, "UserId", "UserId", followings.Followers);
            ViewData["Following"] = new SelectList(_context.Profile, "UserId", "UserId", followings.Following);
            return View(followings);
        }

        // GET: Followings/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var followings = await _context.Followings.FindAsync(id);
            if (followings == null)
            {
                return NotFound();
            }
            ViewData["Followers"] = new SelectList(_context.Profile, "UserId", "UserId", followings.Followers);
            ViewData["Following"] = new SelectList(_context.Profile, "UserId", "UserId", followings.Following);
            return View(followings);
        }

        // POST: Followings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Followers,Following")] Followings followings)
        {
            if (id != followings.Followers)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(followings);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FollowingsExists(followings.Followers))
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
            ViewData["Followers"] = new SelectList(_context.Profile, "UserId", "UserId", followings.Followers);
            ViewData["Following"] = new SelectList(_context.Profile, "UserId", "UserId", followings.Following);
            return View(followings);
        }

        // GET: Followings/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var followings = await _context.Followings
                .Include(f => f.FollowersNavigation)
                .Include(f => f.FollowingNavigation)
                .FirstOrDefaultAsync(m => m.Followers == id);
            if (followings == null)
            {
                return NotFound();
            }

            return View(followings);
        }

        // POST: Followings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var followings = await _context.Followings.FindAsync(id);
            _context.Followings.Remove(followings);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FollowingsExists(string id)
        {
            return _context.Followings.Any(e => e.Followers == id);
        }
    }
}
