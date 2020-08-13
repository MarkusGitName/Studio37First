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
    public class ClassVideosController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/ClassVideos
        public IQueryable<ClassVideo> GetClassVideos()
        {
            return db.ClassVideos;
        }

        // GET: api/ClassVideos/5
        [ResponseType(typeof(ClassVideo))]
        public async Task<IHttpActionResult> GetClassVideo(Guid id)
        {
            ClassVideo classVideo = await db.ClassVideos.FindAsync(id);
            if (classVideo == null)
            {
                return NotFound();
            }

            return Ok(classVideo);
        }

        // PUT: api/ClassVideos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClassVideo(Guid id, ClassVideo classVideo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != classVideo.id)
            {
                return BadRequest();
            }

            db.Entry(classVideo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassVideoExists(id))
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

        // POST: api/ClassVideos
        [ResponseType(typeof(ClassVideo))]
        public async Task<IHttpActionResult> PostClassVideo(ClassVideo classVideo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ClassVideos.Add(classVideo);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClassVideoExists(classVideo.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = classVideo.id }, classVideo);
        }

        // DELETE: api/ClassVideos/5
        [ResponseType(typeof(ClassVideo))]
        public async Task<IHttpActionResult> DeleteClassVideo(Guid id)
        {
            ClassVideo classVideo = await db.ClassVideos.FindAsync(id);
            if (classVideo == null)
            {
                return NotFound();
            }

            db.ClassVideos.Remove(classVideo);
            await db.SaveChangesAsync();

            return Ok(classVideo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClassVideoExists(Guid id)
        {
            return db.ClassVideos.Count(e => e.id == id) > 0;
        }
    }
}