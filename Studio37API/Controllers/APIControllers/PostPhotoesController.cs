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

namespace Studio37API.Controllers.APIControllers
{
    public class PostPhotoesController : ApiController
    {
        private DataModel db = new DataModel();

        // GET: api/PostPhotoes
        public IQueryable<PostPhoto> GetPostPhotos()
        {
            return db.PostPhotos;
        }

        // GET: api/PostPhotoes/5
        [ResponseType(typeof(PostPhoto))]
        public async Task<IHttpActionResult> GetPostPhoto(Guid id)
        {
            PostPhoto postPhoto = await db.PostPhotos.FindAsync(id);
            if (postPhoto == null)
            {
                return NotFound();
            }

            return Ok(postPhoto);
        }

        // PUT: api/PostPhotoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPostPhoto(Guid id, PostPhoto postPhoto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != postPhoto.id)
            {
                return BadRequest();
            }

            db.Entry(postPhoto).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostPhotoExists(id))
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

        // POST: api/PostPhotoes
        [ResponseType(typeof(PostPhoto))]
        public async Task<IHttpActionResult> PostPostPhoto(PostPhoto postPhoto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PostPhotos.Add(postPhoto);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PostPhotoExists(postPhoto.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = postPhoto.id }, postPhoto);
        }

        // DELETE: api/PostPhotoes/5
        [ResponseType(typeof(PostPhoto))]
        public async Task<IHttpActionResult> DeletePostPhoto(Guid id)
        {
            PostPhoto postPhoto = await db.PostPhotos.FindAsync(id);
            if (postPhoto == null)
            {
                return NotFound();
            }

            db.PostPhotos.Remove(postPhoto);
            await db.SaveChangesAsync();

            return Ok(postPhoto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PostPhotoExists(Guid id)
        {
            return db.PostPhotos.Count(e => e.id == id) > 0;
        }
    }
}