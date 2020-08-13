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
    public class UserCattegoriesController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/UserCattegories
        public IQueryable<UserCattegory> GetUserCattegories()
        {
            return db.UserCattegories;
        }

        // GET: api/UserCattegories/5
        [ResponseType(typeof(UserCattegory))]
        public async Task<IHttpActionResult> GetUserCattegory(Guid id)
        {
            UserCattegory userCattegory = await db.UserCattegories.FindAsync(id);
            if (userCattegory == null)
            {
                return NotFound();
            }

            return Ok(userCattegory);
        }

        // PUT: api/UserCattegories/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUserCattegory(Guid id, UserCattegory userCattegory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userCattegory.id)
            {
                return BadRequest();
            }

            db.Entry(userCattegory).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserCattegoryExists(id))
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

        // POST: api/UserCattegories
        [ResponseType(typeof(UserCattegory))]
        public async Task<IHttpActionResult> PostUserCattegory(UserCattegory userCattegory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserCattegories.Add(userCattegory);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserCattegoryExists(userCattegory.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = userCattegory.id }, userCattegory);
        }

        // DELETE: api/UserCattegories/5
        [ResponseType(typeof(UserCattegory))]
        public async Task<IHttpActionResult> DeleteUserCattegory(Guid id)
        {
            UserCattegory userCattegory = await db.UserCattegories.FindAsync(id);
            if (userCattegory == null)
            {
                return NotFound();
            }

            db.UserCattegories.Remove(userCattegory);
            await db.SaveChangesAsync();

            return Ok(userCattegory);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserCattegoryExists(Guid id)
        {
            return db.UserCattegories.Count(e => e.id == id) > 0;
        }
    }
}