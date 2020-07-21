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
    public class MessagesController : Controller
    {
        private readonly AdventureContext _context;

        public MessagesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: Messages
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.Messages.Include(m => m.Chat).Include(m => m.User);
            return View(await adventureContext.ToListAsync());
        }

        // GET: Messages/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messages = await _context.Messages
                .Include(m => m.Chat)
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.MessageId == id);
            if (messages == null)
            {
                return NotFound();
            }

            return View(messages);
        }

        // GET: Messages/Create
        public IActionResult Create()
        {
            ViewData["ChatId"] = new SelectList(_context.Chat, "ChatId", "ChatId");
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId");
            return View();
        }

        // POST: Messages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MessageId,Msge,Date,UserId,ChatId")] Messages messages)
        {
            if (ModelState.IsValid)
            {
                messages.MessageId = Guid.NewGuid();
                _context.Add(messages);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ChatId"] = new SelectList(_context.Chat, "ChatId", "ChatId", messages.ChatId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", messages.UserId);
            return View(messages);
        }

        // GET: Messages/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messages = await _context.Messages.FindAsync(id);
            if (messages == null)
            {
                return NotFound();
            }
            ViewData["ChatId"] = new SelectList(_context.Chat, "ChatId", "ChatId", messages.ChatId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", messages.UserId);
            return View(messages);
        }

        // POST: Messages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("MessageId,Msge,Date,UserId,ChatId")] Messages messages)
        {
            if (id != messages.MessageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(messages);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MessagesExists(messages.MessageId))
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
            ViewData["ChatId"] = new SelectList(_context.Chat, "ChatId", "ChatId", messages.ChatId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", messages.UserId);
            return View(messages);
        }

        // GET: Messages/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messages = await _context.Messages
                .Include(m => m.Chat)
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.MessageId == id);
            if (messages == null)
            {
                return NotFound();
            }

            return View(messages);
        }

        // POST: Messages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var messages = await _context.Messages.FindAsync(id);
            _context.Messages.Remove(messages);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MessagesExists(Guid id)
        {
            return _context.Messages.Any(e => e.MessageId == id);
        }
    }
}
