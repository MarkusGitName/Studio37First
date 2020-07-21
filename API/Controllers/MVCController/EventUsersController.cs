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
    public class EventUsersController : Controller
    {
        private readonly AdventureContext _context;

        public EventUsersController(AdventureContext context)
        {
            _context = context;
        }

        // GET: EventUsers
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.EventUsers.Include(e => e.Event).Include(e => e.User);
            return View(await adventureContext.ToListAsync());
        }

        // GET: EventUsers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventUsers = await _context.EventUsers
                .Include(e => e.Event)
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventUsers == null)
            {
                return NotFound();
            }

            return View(eventUsers);
        }

        // GET: EventUsers/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId");
            return View();
        }

        // POST: EventUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EventId,UserId")] EventUsers eventUsers)
        {
            if (ModelState.IsValid)
            {
                eventUsers.Id = Guid.NewGuid();
                _context.Add(eventUsers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Id", eventUsers.EventId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", eventUsers.UserId);
            return View(eventUsers);
        }

        // GET: EventUsers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventUsers = await _context.EventUsers.FindAsync(id);
            if (eventUsers == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Id", eventUsers.EventId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", eventUsers.UserId);
            return View(eventUsers);
        }

        // POST: EventUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,EventId,UserId")] EventUsers eventUsers)
        {
            if (id != eventUsers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventUsers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventUsersExists(eventUsers.Id))
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
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Id", eventUsers.EventId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", eventUsers.UserId);
            return View(eventUsers);
        }

        // GET: EventUsers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventUsers = await _context.EventUsers
                .Include(e => e.Event)
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventUsers == null)
            {
                return NotFound();
            }

            return View(eventUsers);
        }

        // POST: EventUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var eventUsers = await _context.EventUsers.FindAsync(id);
            _context.EventUsers.Remove(eventUsers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventUsersExists(Guid id)
        {
            return _context.EventUsers.Any(e => e.Id == id);
        }
    }
}
