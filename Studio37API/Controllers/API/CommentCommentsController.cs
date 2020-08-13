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
    public class CommentCommentsController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/CommentComments
        public IQueryable<CommentComment> GetCommentComments()
        {
            return db.CommentComments;
        }

        // GET: api/CommentComments/5
        [ResponseType(typeof(CommentComment))]
        public async Task<IHttpActionResult> GetCommentComment(Guid id)
        {
            CommentComment commentComment = await db.CommentComments.FindAsync(id);
            if (commentComment == null)
            {
                return NotFound();
            }

            return Ok(commentComment);
        }

        // PUT: api/CommentComments/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCommentComment(Guid id, CommentComment commentComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != commentComment.id)
            {
                return BadRequest();
            }

            db.Entry(commentComment).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentCommentExists(id))
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

        // POST: api/CommentComments
        [ResponseType(typeof(CommentComment))]
        public async Task<IHttpActionResult> PostCommentComment(CommentComment commentComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CommentComments.Add(commentComment);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CommentCommentExists(commentComment.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = commentComment.id }, commentComment);
        }

        // DELETE: api/CommentComments/5
        [ResponseType(typeof(CommentComment))]
        public async Task<IHttpActionResult> DeleteCommentComment(Guid id)
        {
            CommentComment commentComment = await db.CommentComments.FindAsync(id);
            if (commentComment == null)
            {
                return NotFound();
            }

            db.CommentComments.Remove(commentComment);
            await db.SaveChangesAsync();

            return Ok(commentComment);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CommentCommentExists(Guid id)
        {
            return db.CommentComments.Count(e => e.id == id) > 0;
        }
    }
}