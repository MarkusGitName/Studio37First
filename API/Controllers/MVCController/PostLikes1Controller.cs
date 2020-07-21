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
    public class PostLikes1Controller : Controller
    {
        private readonly AdventureContext _context;

        public PostLikes1Controller(AdventureContext context)
        {
            _context = context;
        }

        // GET: PostLikes1
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.PostLike.Include(p => p.Like).Include(p => p.Post);
            return View(await adventureContext.ToListAsync());
        }

        // GET: PostLikes1/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postLike = await _context.PostLike
                .Include(p => p.Like)
                .Include(p => p.Post)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (postLike == null)
            {
                return NotFound();
            }

            return View(postLike);
        }

        // GET: PostLikes1/Create
        public IActionResult Create()
        {
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id");
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id");
            return View();
        }

        // POST: PostLikes1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,LikeId")] PostLike postLike)
        {
            if (ModelState.IsValid)
            {
                postLike.PostId = Guid.NewGuid();
                _context.Add(postLike);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id", postLike.LikeId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postLike.PostId);
            return View(postLike);
        }

        // GET: PostLikes1/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postLike = await _context.PostLike.FindAsync(id);
            if (postLike == null)
            {
                return NotFound();
            }
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id", postLike.LikeId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postLike.PostId);
            return View(postLike);
        }

        // POST: PostLikes1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("PostId,LikeId")] PostLike postLike)
        {
            if (id != postLike.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postLike);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostLikeExists(postLike.PostId))
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
            ViewData["LikeId"] = new SelectList(_context.Like, "Id", "Id", postLike.LikeId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postLike.PostId);
            return View(postLike);
        }

        // GET: PostLikes1/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postLike = await _context.PostLike
                .Include(p => p.Like)
                .Include(p => p.Post)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (postLike == null)
            {
                return NotFound();
            }

            return View(postLike);
        }

        // POST: PostLikes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var postLike = await _context.PostLike.FindAsync(id);
            _context.PostLike.Remove(postLike);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostLikeExists(Guid id)
        {
            return _context.PostLike.Any(e => e.PostId == id);
        }
    }
}
