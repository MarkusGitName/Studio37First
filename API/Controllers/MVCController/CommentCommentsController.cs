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
    public class CommentCommentsController : Controller
    {
        private readonly AdventureContext _context;

        public CommentCommentsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: CommentComments
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.CommentComments.Include(c => c.NewCommentNavigation).Include(c => c.OldCommentNavigation);
            return View(await adventureContext.ToListAsync());
        }

        // GET: CommentComments/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentComments = await _context.CommentComments
                .Include(c => c.NewCommentNavigation)
                .Include(c => c.OldCommentNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commentComments == null)
            {
                return NotFound();
            }

            return View(commentComments);
        }

        // GET: CommentComments/Create
        public IActionResult Create()
        {
            ViewData["NewComment"] = new SelectList(_context.Comments, "Id", "Id");
            ViewData["OldComment"] = new SelectList(_context.Comments, "Id", "Id");
            return View();
        }

        // POST: CommentComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OldComment,NewComment")] CommentComments commentComments)
        {
            if (ModelState.IsValid)
            {
                commentComments.Id = Guid.NewGuid();
                _context.Add(commentComments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NewComment"] = new SelectList(_context.Comments, "Id", "Id", commentComments.NewComment);
            ViewData["OldComment"] = new SelectList(_context.Comments, "Id", "Id", commentComments.OldComment);
            return View(commentComments);
        }

        // GET: CommentComments/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentComments = await _context.CommentComments.FindAsync(id);
            if (commentComments == null)
            {
                return NotFound();
            }
            ViewData["NewComment"] = new SelectList(_context.Comments, "Id", "Id", commentComments.NewComment);
            ViewData["OldComment"] = new SelectList(_context.Comments, "Id", "Id", commentComments.OldComment);
            return View(commentComments);
        }

        // POST: CommentComments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,OldComment,NewComment")] CommentComments commentComments)
        {
            if (id != commentComments.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(commentComments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentCommentsExists(commentComments.Id))
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
            ViewData["NewComment"] = new SelectList(_context.Comments, "Id", "Id", commentComments.NewComment);
            ViewData["OldComment"] = new SelectList(_context.Comments, "Id", "Id", commentComments.OldComment);
            return View(commentComments);
        }

        // GET: CommentComments/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentComments = await _context.CommentComments
                .Include(c => c.NewCommentNavigation)
                .Include(c => c.OldCommentNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commentComments == null)
            {
                return NotFound();
            }

            return View(commentComments);
        }

        // POST: CommentComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var commentComments = await _context.CommentComments.FindAsync(id);
            _context.CommentComments.Remove(commentComments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommentCommentsExists(Guid id)
        {
            return _context.CommentComments.Any(e => e.Id == id);
        }
    }
}
