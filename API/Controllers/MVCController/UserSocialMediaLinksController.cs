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
    public class UserSocialMediaLinksController : Controller
    {
        private readonly AdventureContext _context;

        public UserSocialMediaLinksController(AdventureContext context)
        {
            _context = context;
        }

        // GET: UserSocialMediaLinks
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.UserSocialMediaLinks.Include(u => u.User);
            return View(await adventureContext.ToListAsync());
        }

        // GET: UserSocialMediaLinks/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userSocialMediaLinks = await _context.UserSocialMediaLinks
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userSocialMediaLinks == null)
            {
                return NotFound();
            }

            return View(userSocialMediaLinks);
        }

        // GET: UserSocialMediaLinks/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId");
            return View();
        }

        // POST: UserSocialMediaLinks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,Link")] UserSocialMediaLinks userSocialMediaLinks)
        {
            if (ModelState.IsValid)
            {
                userSocialMediaLinks.Id = Guid.NewGuid();
                _context.Add(userSocialMediaLinks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", userSocialMediaLinks.UserId);
            return View(userSocialMediaLinks);
        }

        // GET: UserSocialMediaLinks/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userSocialMediaLinks = await _context.UserSocialMediaLinks.FindAsync(id);
            if (userSocialMediaLinks == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", userSocialMediaLinks.UserId);
            return View(userSocialMediaLinks);
        }

        // POST: UserSocialMediaLinks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UserId,Link")] UserSocialMediaLinks userSocialMediaLinks)
        {
            if (id != userSocialMediaLinks.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userSocialMediaLinks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserSocialMediaLinksExists(userSocialMediaLinks.Id))
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
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", userSocialMediaLinks.UserId);
            return View(userSocialMediaLinks);
        }

        // GET: UserSocialMediaLinks/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userSocialMediaLinks = await _context.UserSocialMediaLinks
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userSocialMediaLinks == null)
            {
                return NotFound();
            }

            return View(userSocialMediaLinks);
        }

        // POST: UserSocialMediaLinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var userSocialMediaLinks = await _context.UserSocialMediaLinks.FindAsync(id);
            _context.UserSocialMediaLinks.Remove(userSocialMediaLinks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserSocialMediaLinksExists(Guid id)
        {
            return _context.UserSocialMediaLinks.Any(e => e.Id == id);
        }
    }
}
