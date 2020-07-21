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
    public class PostVideosController : Controller
    {
        private readonly AdventureContext _context;

        public PostVideosController(AdventureContext context)
        {
            _context = context;
        }

        // GET: PostVideos
        public async Task<IActionResult> Index()
        {
            var adventureContext = _context.PostVideo.Include(p => p.Post).Include(p => p.Video);
            return View(await adventureContext.ToListAsync());
        }

        // GET: PostVideos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postVideo = await _context.PostVideo
                .Include(p => p.Post)
                .Include(p => p.Video)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postVideo == null)
            {
                return NotFound();
            }

            return View(postVideo);
        }

        // GET: PostVideos/Create
        public IActionResult Create()
        {
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id");
            ViewData["VideoId"] = new SelectList(_context.Videos, "Id", "Id");
            return View();
        }

        // POST: PostVideos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PostId,VideoId")] PostVideo postVideo)
        {
            if (ModelState.IsValid)
            {
                postVideo.Id = Guid.NewGuid();
                _context.Add(postVideo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postVideo.PostId);
            ViewData["VideoId"] = new SelectList(_context.Videos, "Id", "Id", postVideo.VideoId);
            return View(postVideo);
        }

        // GET: PostVideos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postVideo = await _context.PostVideo.FindAsync(id);
            if (postVideo == null)
            {
                return NotFound();
            }
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postVideo.PostId);
            ViewData["VideoId"] = new SelectList(_context.Videos, "Id", "Id", postVideo.VideoId);
            return View(postVideo);
        }

        // POST: PostVideos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,PostId,VideoId")] PostVideo postVideo)
        {
            if (id != postVideo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postVideo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostVideoExists(postVideo.Id))
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
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id", postVideo.PostId);
            ViewData["VideoId"] = new SelectList(_context.Videos, "Id", "Id", postVideo.VideoId);
            return View(postVideo);
        }

        // GET: PostVideos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postVideo = await _context.PostVideo
                .Include(p => p.Post)
                .Include(p => p.Video)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postVideo == null)
            {
                return NotFound();
            }

            return View(postVideo);
        }

        // POST: PostVideos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var postVideo = await _context.PostVideo.FindAsync(id);
            _context.PostVideo.Remove(postVideo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostVideoExists(Guid id)
        {
            return _context.PostVideo.Any(e => e.Id == id);
        }
    }
}
