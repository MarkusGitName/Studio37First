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
    public class GroupUsersController : Controller
    {
        private readonly AdventureContext _context;

        public GroupUsersController(AdventureContext context)
        {
            _context = context;
        }

        // GET: GroupUsers
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.GroupUser.Include(g => g.Group).Include(g => g.User);
            return View(await adventureContext.ToListAsync());
        }

        // GET: GroupUsers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupUser = await _context.GroupUser
                .Include(g => g.Group)
                .Include(g => g.User)
                .FirstOrDefaultAsync(m => m.Groupid == id);
            if (groupUser == null)
            {
                return NotFound();
            }

            return View(groupUser);
        }

        // GET: GroupUsers/Create
        public IActionResult Create()
        {
            ViewData["Groupid"] = new SelectList(_context.Groups, "Id", "Id");
            ViewData["Userid"] = new SelectList(_context.Profile, "UserId", "UserId");
            return View();
        }

        // POST: GroupUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Groupid,Userid")] GroupUser groupUser)
        {
            if (ModelState.IsValid)
            {
                groupUser.Groupid = Guid.NewGuid();
                _context.Add(groupUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Groupid"] = new SelectList(_context.Groups, "Id", "Id", groupUser.Groupid);
            ViewData["Userid"] = new SelectList(_context.Profile, "UserId", "UserId", groupUser.Userid);
            return View(groupUser);
        }

        // GET: GroupUsers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupUser = await _context.GroupUser.FindAsync(id);
            if (groupUser == null)
            {
                return NotFound();
            }
            ViewData["Groupid"] = new SelectList(_context.Groups, "Id", "Id", groupUser.Groupid);
            ViewData["Userid"] = new SelectList(_context.Profile, "UserId", "UserId", groupUser.Userid);
            return View(groupUser);
        }

        // POST: GroupUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Groupid,Userid")] GroupUser groupUser)
        {
            if (id != groupUser.Groupid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupUserExists(groupUser.Groupid))
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
            ViewData["Groupid"] = new SelectList(_context.Groups, "Id", "Id", groupUser.Groupid);
            ViewData["Userid"] = new SelectList(_context.Profile, "UserId", "UserId", groupUser.Userid);
            return View(groupUser);
        }

        // GET: GroupUsers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupUser = await _context.GroupUser
                .Include(g => g.Group)
                .Include(g => g.User)
                .FirstOrDefaultAsync(m => m.Groupid == id);
            if (groupUser == null)
            {
                return NotFound();
            }

            return View(groupUser);
        }

        // POST: GroupUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var groupUser = await _context.GroupUser.FindAsync(id);
            _context.GroupUser.Remove(groupUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupUserExists(Guid id)
        {
            return _context.GroupUser.Any(e => e.Groupid == id);
        }
    }
}
