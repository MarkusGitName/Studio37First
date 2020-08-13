using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Studio37API.Models.DataBaseMdels;

namespace Studio37API.Controllers.API
{
    public class PostCattegoriesController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/PostCattegories
        public IQueryable<PostCattegory> GetPostCattegories()
        {
            return db.PostCattegories;
        }

        // GET: api/PostCattegories/5
        [ResponseType(typeof(PostCattegory))]
        public async Task<IHttpActionResult> GetPostCattegory(Guid id)
        {
            PostCattegory postCattegory = await db.PostCattegories.FindAsync(id);
            if (postCattegory == null)
            {
                return NotFound();
            }

            return Ok(postCattegory);
        }

        // PUT: api/PostCattegories/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPostCattegory(Guid id, PostCattegory postCattegory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != postCattegory.id)
            {
                return BadRequest();
            }

            db.Entry(postCattegory).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostCattegoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/PostCattegories
        [ResponseType(typeof(PostCattegory))]
        public async Task<IHttpActionResult> PostPostCattegory(PostCattegory postCattegory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PostCattegories.Add(postCattegory);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PostCattegoryExists(postCattegory.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = postCattegory.id }, postCattegory);
        }

        // DELETE: api/PostCattegories/5
        [ResponseType(typeof(PostCattegory))]
        public async Task<IHttpActionResult> DeletePostCattegory(Guid id)
        {
            PostCattegory postCattegory = await db.PostCattegories.FindAsync(id);
            if (postCattegory == null)
            {
                return NotFound();
            }

            db.PostCattegories.Remove(postCattegory);
            await db.SaveChangesAsync();

            return Ok(postCattegory);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PostCattegoryExists(Guid id)
        {
            return db.PostCattegories.Count(e => e.id == id) > 0;
        }
    }
}