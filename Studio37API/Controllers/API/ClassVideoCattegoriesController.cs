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
    public class ClassVideoCattegoriesController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/ClassVideoCattegories
        public List<ClassVideoCattegoryViewModel> GetClassVideoCattegories()
        {
            List<ClassVideoCattegoryViewModel> ClassVideoCattegoryList = new List<ClassVideoCattegoryViewModel>;

            foreach(ClassVideoCattegory incomingClassVideoCattegory in db.ClassVideoCattegories)
            {
                ClassVideoCattegoryList.Add(new ClassVideoCattegoryViewModel(incomingClassVideoCattegory));
            }

            return ClassVideoCattegoryList;
        }

        // GET: api/ClassVideoCattegories/5
        [ResponseType(typeof(ClassVideoCattegory))]
        public async Task<IHttpActionResult> GetClassVideoCattegory(Guid id)
        {
            ClassVideoCattegory classVideoCattegory = await db.ClassVideoCattegories.FindAsync(id);
            if (classVideoCattegory == null)
            {
                return NotFound();
            }

            return Ok(new ClassVideoCattegoryViewModel(classVideoCattegory));
        }

        // PUT: api/ClassVideoCattegories/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClassVideoCattegory(Guid id, ClassVideoCattegory classVideoCattegory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != classVideoCattegory.id)
            {
                return BadRequest();
            }

            db.Entry(classVideoCattegory).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
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

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ClassVideoCattegories
        [ResponseType(typeof(ClassVideoCattegory))]
        public async Task<IHttpActionResult> PostClassVideoCattegory(ClassVideoCattegory classVideoCattegory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ClassVideoCattegories.Add(classVideoCattegory);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClassVideoCattegoryExists(classVideoCattegory.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = classVideoCattegory.id }, new ClassVideoCattegoryViewModel(classVideoCattegory));
        }

        // DELETE: api/ClassVideoCattegories/5
        [ResponseType(typeof(ClassVideoCattegory))]
        public async Task<IHttpActionResult> DeleteClassVideoCattegory(Guid id)
        {
            ClassVideoCattegory classVideoCattegory = await db.ClassVideoCattegories.FindAsync(id);
            if (classVideoCattegory == null)
            {
                return NotFound();
            }

            db.ClassVideoCattegories.Remove(classVideoCattegory);
            await db.SaveChangesAsync();

            return Ok(new ClassVideoCattegoryViewModel(classVideoCattegory));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClassVideoCattegoryExists(Guid id)
        {
            return db.ClassVideoCattegories.Count(e => e.id == id) > 0;
        }
    }
}