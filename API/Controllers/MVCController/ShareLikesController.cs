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
    public class ShareLikesController : Controller
    {
        private readonly AdventureContext _context;

        public ShareLikesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: ShareLikes
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.ShareLikes.Include(s => s.Like).Include(s => s.Share);
            return View(await adventureContext.ToListAsync());
        }

        // GET: ShareLikes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shareLikes = await _context.ShareLikes
                .Include(s => s.Like)
                .Include(s => s.Share)
                .FirstOrDefaultAsync(m => m.ShareId == id);
            if (shareLikes == null)
            {
                return NotFound();
            }

            return View(shareLikes);
        }

        // GET: ShareLikes/Create
        public IActionResult Create()
        {
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id");
            ViewData["ShareId"] = new SelectList(_context.Share, "Id", "Id");
            return View();
        }

        // POST: ShareLikes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShareId,LikeId")] ShareLikes shareLikes)
        {
            if (ModelState.IsValid)
            {
                shareLikes.ShareId = Guid.NewGuid();
                _context.Add(shareLikes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id", shareLikes.LikeId);
            ViewData["ShareId"] = new SelectList(_context.Share, "Id", "Id", shareLikes.ShareId);
            return View(shareLikes);
        }

        // GET: ShareLikes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shareLikes = await _context.ShareLikes.FindAsync(id);
            if (shareLikes == null)
            {
                return NotFound();
            }
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id", shareLikes.LikeId);
            ViewData["ShareId"] = new SelectList(_context.Share, "Id", "Id", shareLikes.ShareId);
            return View(shareLikes);
        }

        // POST: ShareLikes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ShareId,LikeId")] ShareLikes shareLikes)
        {
            if (id != shareLikes.ShareId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shareLikes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShareLikesExists(shareLikes.ShareId))
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
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id", shareLikes.LikeId);
            ViewData["ShareId"] = new SelectList(_context.Share, "Id", "Id", shareLikes.ShareId);
            return View(shareLikes);
        }

        // GET: ShareLikes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shareLikes = await _context.ShareLikes
                .Include(s => s.Like)
                .Include(s => s.Share)
                .FirstOrDefaultAsync(m => m.ShareId == id);
            if (shareLikes == null)
            {
                return NotFound();
            }

            return View(shareLikes);
        }

        // POST: ShareLikes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var shareLikes = await _context.ShareLikes.FindAsync(id);
            _context.ShareLikes.Remove(shareLikes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShareLikesExists(Guid id)
        {
            return _context.ShareLikes.Any(e => e.ShareId == id);
        }
    }
}
