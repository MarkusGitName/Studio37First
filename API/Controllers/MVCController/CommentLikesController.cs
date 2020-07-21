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
    public class CommentLikesController : Controller
    {
        private readonly AdventureContext _context;

        public CommentLikesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: CommentLikes
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.CommentLikes.Include(c => c.Comment).Include(c => c.Like);
            return View(await adventureContext.ToListAsync());
        }

        // GET: CommentLikes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentLikes = await _context.CommentLikes
                .Include(c => c.Comment)
                .Include(c => c.Like)
                .FirstOrDefaultAsync(m => m.CommentId == id);
            if (commentLikes == null)
            {
                return NotFound();
            }

            return View(commentLikes);
        }

        // GET: CommentLikes/Create
        public IActionResult Create()
        {
            ViewData["CommentId"] = new SelectList(_context.Comments, "Id", "Id");
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id");
            return View();
        }

        // POST: CommentLikes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CommentId,LikeId")] CommentLikes commentLikes)
        {
            if (ModelState.IsValid)
            {
                commentLikes.CommentId = Guid.NewGuid();
                _context.Add(commentLikes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CommentId"] = new SelectList(_context.Comments, "Id", "Id", commentLikes.CommentId);
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id", commentLikes.LikeId);
            return View(commentLikes);
        }

        // GET: CommentLikes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentLikes = await _context.CommentLikes.FindAsync(id);
            if (commentLikes == null)
            {
                return NotFound();
            }
            ViewData["CommentId"] = new SelectList(_context.Comments, "Id", "Id", commentLikes.CommentId);
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id", commentLikes.LikeId);
            return View(commentLikes);
        }

        // POST: CommentLikes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CommentId,LikeId")] CommentLikes commentLikes)
        {
            if (id != commentLikes.CommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(commentLikes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentLikesExists(commentLikes.CommentId))
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
            ViewData["CommentId"] = new SelectList(_context.Comments, "Id", "Id", commentLikes.CommentId);
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id", commentLikes.LikeId);
            return View(commentLikes);
        }

        // GET: CommentLikes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentLikes = await _context.CommentLikes
                .Include(c => c.Comment)
                .Include(c => c.Like)
                .FirstOrDefaultAsync(m => m.CommentId == id);
            if (commentLikes == null)
            {
                return NotFound();
            }

            return View(commentLikes);
        }

        // POST: CommentLikes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var commentLikes = await _context.CommentLikes.FindAsync(id);
            _context.CommentLikes.Remove(commentLikes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommentLikesExists(Guid id)
        {
            return _context.CommentLikes.Any(e => e.CommentId == id);
        }
    }
}
