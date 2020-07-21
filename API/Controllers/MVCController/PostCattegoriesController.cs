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
    public class PostCattegoriesController : Controller
    {
        private readonly AdventureContext _context;

        public PostCattegoriesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: PostCattegories
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.PostCattegory.Include(p => p.Post).Include(p => p.PostNavigation);
            return View(await adventureContext.ToListAsync());
        }

        // GET: PostCattegories/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postCattegory = await _context.PostCattegory
                .Include(p => p.Post)
                .Include(p => p.PostNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postCattegory == null)
            {
                return NotFound();
            }

            return View(postCattegory);
        }

        // GET: PostCattegories/Create
        public IActionResult Create()
        {
            ViewData["PostId"] = new SelectList(_context.Categories, "Id", "Id");
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id");
            return View();
        }

        // POST: PostCattegories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PostId,CategoryId")] PostCattegory postCattegory)
        {
            if (ModelState.IsValid)
            {
                postCattegory.Id = Guid.NewGuid();
                _context.Add(postCattegory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PostId"] = new SelectList(_context.Categories, "Id", "Id", postCattegory.PostId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postCattegory.PostId);
            return View(postCattegory);
        }

        // GET: PostCattegories/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postCattegory = await _context.PostCattegory.FindAsync(id);
            if (postCattegory == null)
            {
                return NotFound();
            }
            ViewData["PostId"] = new SelectList(_context.Categories, "Id", "Id", postCattegory.PostId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postCattegory.PostId);
            return View(postCattegory);
        }

        // POST: PostCattegories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,PostId,CategoryId")] PostCattegory postCattegory)
        {
            if (id != postCattegory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postCattegory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostCattegoryExists(postCattegory.Id))
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
            ViewData["PostId"] = new SelectList(_context.Categories, "Id", "Id", postCattegory.PostId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postCattegory.PostId);
            return View(postCattegory);
        }

        // GET: PostCattegories/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postCattegory = await _context.PostCattegory
                .Include(p => p.Post)
                .Include(p => p.PostNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postCattegory == null)
            {
                return NotFound();
            }

            return View(postCattegory);
        }

        // POST: PostCattegories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var postCattegory = await _context.PostCattegory.FindAsync(id);
            _context.PostCattegory.Remove(postCattegory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostCattegoryExists(Guid id)
        {
            return _context.PostCattegory.Any(e => e.Id == id);
        }
    }
}
