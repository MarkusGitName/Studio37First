using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Model;

namespace API.Controllers.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassVideoCattegoriesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public ClassVideoCattegoriesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/ClassVideoCattegories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassVideoCattegory>>> GetClassVideoCattegory()
        {
            return await _context.ClassVideoCattegory.ToListAsync();
        }

        // GET: api/ClassVideoCattegories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassVideoCattegory>> GetClassVideoCattegory(Guid id)
        {
            var classVideoCattegory = await _context.ClassVideoCattegory.FindAsync(id);

            if (classVideoCattegory == null)
            {
                return NotFound();
            }

            return classVideoCattegory;
        }

        // PUT: api/ClassVideoCattegories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClassVideoCattegory(Guid id, ClassVideoCattegory classVideoCattegory)
        {
            if (id != classVideoCattegory.Id)
            {
                return BadRequest();
            }

            _context.Entry(classVideoCattegory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassVideoCattegoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ClassVideoCattegories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ClassVideoCattegory>> PostClassVideoCattegory(ClassVideoCattegory classVideoCattegory)
        {
            _context.ClassVideoCattegory.Add(classVideoCattegory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClassVideoCattegoryExists(classVideoCattegory.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetClassVideoCattegory", new { id = classVideoCattegory.Id }, classVideoCattegory);
        }

        // DELETE: api/ClassVideoCattegories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ClassVideoCattegory>> DeleteClassVideoCattegory(Guid id)
        {
            var classVideoCattegory = await _context.ClassVideoCattegory.FindAsync(id);
            if (classVideoCattegory == null)
            {
                return NotFound();
            }

            _context.ClassVideoCattegory.Remove(classVideoCattegory);
            await _context.SaveChangesAsync();

            return classVideoCattegory;
        }

        private bool ClassVideoCattegoryExists(Guid id)
        {
            return _context.ClassVideoCattegory.Any(e => e.Id == id);
        }
    }
}
