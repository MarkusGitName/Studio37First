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
    public class ClassVideosController : Controller
    {
        private readonly AdventureContext _context;

        public ClassVideosController(AdventureContext context)
        {
            _context = context;
        }

        // GET: ClassVideos
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClassVideo.ToListAsync());
        }

        // GET: ClassVideos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classVideo = await _context.ClassVideo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classVideo == null)
            {
                return NotFound();
            }

            return View(classVideo);
        }

        // GET: ClassVideos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClassVideos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VideoPath,Price,DateAdded,Title,Description,VideoThumbnail")] ClassVideo classVideo)
        {
            if (ModelState.IsValid)
            {
                classVideo.Id = Guid.NewGuid();
                _context.Add(classVideo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(classVideo);
        }

        // GET: ClassVideos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classVideo = await _context.ClassVideo.FindAsync(id);
            if (classVideo == null)
            {
                return NotFound();
            }
            return View(classVideo);
        }

        // POST: ClassVideos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,VideoPath,Price,DateAdded,Title,Description,VideoThumbnail")] ClassVideo classVideo)
        {
            if (id != classVideo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classVideo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassVideoExists(classVideo.Id))
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
            return View(classVideo);
        }

        // GET: ClassVideos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classVideo = await _context.ClassVideo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classVideo == null)
            {
                return NotFound();
            }

            return View(classVideo);
        }

        // POST: ClassVideos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var classVideo = await _context.ClassVideo.FindAsync(id);
            _context.ClassVideo.Remove(classVideo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassVideoExists(Guid id)
        {
            return _context.ClassVideo.Any(e => e.Id == id);
        }
    }
}
