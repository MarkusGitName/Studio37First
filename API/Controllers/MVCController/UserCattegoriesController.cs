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
    public class UserCattegoriesController : Controller
    {
        private readonly AdventureContext _context;

        public UserCattegoriesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: UserCattegories
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.UserCattegory.Include(u => u.Cattegorry).Include(u => u.User);
            return View(await adventureContext.ToListAsync());
        }

        // GET: UserCattegories/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userCattegory = await _context.UserCattegory
                .Include(u => u.Cattegorry)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userCattegory == null)
            {
                return NotFound();
            }

            return View(userCattegory);
        }

        // GET: UserCattegories/Create
        public IActionResult Create()
        {
            ViewData["CattegorryId"] = new SelectList(_context.Categories, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId");
            return View();
        }

        // POST: UserCattegories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,CattegorryId")] UserCattegory userCattegory)
        {
            if (ModelState.IsValid)
            {
                userCattegory.Id = Guid.NewGuid();
                _context.Add(userCattegory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CattegorryId"] = new SelectList(_context.Categories, "Id", "Id", userCattegory.CattegorryId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", userCattegory.UserId);
            return View(userCattegory);
        }

        // GET: UserCattegories/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userCattegory = await _context.UserCattegory.FindAsync(id);
            if (userCattegory == null)
            {
                return NotFound();
            }
            ViewData["CattegorryId"] = new SelectList(_context.Categories, "Id", "Id", userCattegory.CattegorryId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", userCattegory.UserId);
            return View(userCattegory);
        }

        // POST: UserCattegories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UserId,CattegorryId")] UserCattegory userCattegory)
        {
            if (id != userCattegory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userCattegory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserCattegoryExists(userCattegory.Id))
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
            ViewData["CattegorryId"] = new SelectList(_context.Categories, "Id", "Id", userCattegory.CattegorryId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", userCattegory.UserId);
            return View(userCattegory);
        }

        // GET: UserCattegories/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userCattegory = await _context.UserCattegory
                .Include(u => u.Cattegorry)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userCattegory == null)
            {
                return NotFound();
            }

            return View(userCattegory);
        }

        // POST: UserCattegories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var userCattegory = await _context.UserCattegory.FindAsync(id);
            _context.UserCattegory.Remove(userCattegory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserCattegoryExists(Guid id)
        {
            return _context.UserCattegory.Any(e => e.Id == id);
        }
    }
}
