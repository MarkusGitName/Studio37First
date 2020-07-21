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
    public class PostCommentsController : Controller
    {
        private readonly AdventureContext _context;

        public PostCommentsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: PostComments
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.PostComments.Include(p => p.Comment).Include(p => p.Post);
            return View(await adventureContext.ToListAsync());
        }

        // GET: PostComments/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postComments = await _context.PostComments
                .Include(p => p.Comment)
                .Include(p => p.Post)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postComments == null)
            {
                return NotFound();
            }

            return View(postComments);
        }

        // GET: PostComments/Create
        public IActionResult Create()
        {
            ViewData["CommentId"] = new SelectList(_context.Comments, "Id", "Id");
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id");
            return View();
        }

        // POST: PostComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PostId,CommentId")] PostComments postComments)
        {
            if (ModelState.IsValid)
            {
                postComments.Id = Guid.NewGuid();
                _context.Add(postComments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CommentId"] = new SelectList(_context.Comments, "Id", "Id", postComments.CommentId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postComments.PostId);
            return View(postComments);
        }

        // GET: PostComments/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postComments = await _context.PostComments.FindAsync(id);
            if (postComments == null)
            {
                return NotFound();
            }
            ViewData["CommentId"] = new SelectList(_context.Comments, "Id", "Id", postComments.CommentId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postComments.PostId);
            return View(postComments);
        }

        // POST: PostComments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,PostId,CommentId")] PostComments postComments)
        {
            if (id != postComments.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postComments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostCommentsExists(postComments.Id))
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
            ViewData["CommentId"] = new SelectList(_context.Comments, "Id", "Id", postComments.CommentId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postComments.PostId);
            return View(postComments);
        }

        // GET: PostComments/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postComments = await _context.PostComments
                .Include(p => p.Comment)
                .Include(p => p.Post)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postComments == null)
            {
                return NotFound();
            }

            return View(postComments);
        }

        // POST: PostComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var postComments = await _context.PostComments.FindAsync(id);
            _context.PostComments.Remove(postComments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostCommentsExists(Guid id)
        {
            return _context.PostComments.Any(e => e.Id == id);
        }
    }
}
