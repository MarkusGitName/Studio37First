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
    public class UserChatsController : Controller
    {
        private readonly AdventureContext _context;

        public UserChatsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: UserChats
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.UserChat.Include(u => u.Chat).Include(u => u.User);
            return View(await adventureContext.ToListAsync());
        }

        // GET: UserChats/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userChat = await _context.UserChat
                .Include(u => u.Chat)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userChat == null)
            {
                return NotFound();
            }

            return View(userChat);
        }

        // GET: UserChats/Create
        public IActionResult Create()
        {
            ViewData["ChatId"] = new SelectList(_context.Chat, "ChatId", "ChatId");
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId");
            return View();
        }

        // POST: UserChats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,ChatId,Id")] UserChat userChat)
        {
            if (ModelState.IsValid)
            {
                userChat.Id = Guid.NewGuid();
                _context.Add(userChat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ChatId"] = new SelectList(_context.Chat, "ChatId", "ChatId", userChat.ChatId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", userChat.UserId);
            return View(userChat);
        }

        // GET: UserChats/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userChat = await _context.UserChat.FindAsync(id);
            if (userChat == null)
            {
                return NotFound();
            }
            ViewData["ChatId"] = new SelectList(_context.Chat, "ChatId", "ChatId", userChat.ChatId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", userChat.UserId);
            return View(userChat);
        }

        // POST: UserChats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("UserId,ChatId,Id")] UserChat userChat)
        {
            if (id != userChat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userChat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserChatExists(userChat.Id))
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
            ViewData["ChatId"] = new SelectList(_context.Chat, "ChatId", "ChatId", userChat.ChatId);
            ViewData["UserId"] = new SelectList(_context.Profile, "UserId", "UserId", userChat.UserId);
            return View(userChat);
        }

        // GET: UserChats/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userChat = await _context.UserChat
                .Include(u => u.Chat)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userChat == null)
            {
                return NotFound();
            }

            return View(userChat);
        }

        // POST: UserChats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var userChat = await _context.UserChat.FindAsync(id);
            _context.UserChat.Remove(userChat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserChatExists(Guid id)
        {
            return _context.UserChat.Any(e => e.Id == id);
        }
    }
}
