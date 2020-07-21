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
    public class EventGroupsController : Controller
    {
        private readonly AdventureContext _context;

        public EventGroupsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: EventGroups
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.EventGroups.Include(e => e.Event).Include(e => e.Group);
            return View(await adventureContext.ToListAsync());
        }

        // GET: EventGroups/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventGroups = await _context.EventGroups
                .Include(e => e.Event)
                .Include(e => e.Group)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventGroups == null)
            {
                return NotFound();
            }

            return View(eventGroups);
        }

        // GET: EventGroups/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Id");
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Id");
            return View();
        }

        // POST: EventGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EventId,GroupId")] EventGroups eventGroups)
        {
            if (ModelState.IsValid)
            {
                eventGroups.Id = Guid.NewGuid();
                _context.Add(eventGroups);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Id", eventGroups.EventId);
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Id", eventGroups.GroupId);
            return View(eventGroups);
        }

        // GET: EventGroups/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventGroups = await _context.EventGroups.FindAsync(id);
            if (eventGroups == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Id", eventGroups.EventId);
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Id", eventGroups.GroupId);
            return View(eventGroups);
        }

        // POST: EventGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,EventId,GroupId")] EventGroups eventGroups)
        {
            if (id != eventGroups.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventGroups);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventGroupsExists(eventGroups.Id))
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
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Id", eventGroups.EventId);
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Id", eventGroups.GroupId);
            return View(eventGroups);
        }

        // GET: EventGroups/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventGroups = await _context.EventGroups
                .Include(e => e.Event)
                .Include(e => e.Group)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventGroups == null)
            {
                return NotFound();
            }

            return View(eventGroups);
        }

        // POST: EventGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var eventGroups = await _context.EventGroups.FindAsync(id);
            _context.EventGroups.Remove(eventGroups);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventGroupsExists(Guid id)
        {
            return _context.EventGroups.Any(e => e.Id == id);
        }
    }
}
