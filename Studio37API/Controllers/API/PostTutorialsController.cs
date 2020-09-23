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
using Studio37API.Models.ViewModels;

namespace Studio37API.Controllers.API
{
    public class PostTutorialsController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/PostTutorials
        public List<PostTutorialViewModel> GetPostTutorials()
        {
            List<PostTutorialViewModel> PostTutorialList = new List<PostTutorialViewModel>();

            foreach(PostTutorial incomingPostTutorial in db.PostTutorials)
            {
                PostTutorialList.Add(new PostTutorialViewModel(incomingPostTutorial));
            }

            return PostTutorialList;
        }

        // GET: api/PostTutorials/5
        [ResponseType(typeof(PostTutorial))]
        public async Task<IHttpActionResult> GetPostTutorial(Guid id)
        {
            PostTutorial postTutorial = await db.PostTutorials.FindAsync(id);
            if (postTutorial == null)
            {
                return NotFound();
            }

            return Ok(new PostTutorialViewModel(postTutorial));
        }

        // PUT: api/PostTutorials/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPostTutorial(Guid id, PostTutorial postTutorial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != postTutorial.id)
            {
                return BadRequest();
            }

            db.Entry(postTutorial).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostTutorialExists(id))
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

        // POST: api/PostTutorials
        [ResponseType(typeof(PostTutorial))]
        public async Task<IHttpActionResult> PostPostTutorial(PostTutorial postTutorial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PostTutorials.Add(postTutorial);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PostTutorialExists(postTutorial.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = postTutorial.id }, new PostTutorialViewModel(postTutorial));
        }

        // DELETE: api/PostTutorials/5
        [ResponseType(typeof(PostTutorial))]
        public async Task<IHttpActionResult> DeletePostTutorial(Guid id)
        {
            PostTutorial postTutorial = await db.PostTutorials.FindAsync(id);
            if (postTutorial == null)
            {
                return NotFound();
            }

            db.PostTutorials.Remove(postTutorial);
            await db.SaveChangesAsync();

            return Ok(new PostTutorialViewModel(postTutorial));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PostTutorialExists(Guid id)
        {
            return db.PostTutorials.Count(e => e.id == id) > 0;
        }
    }
}