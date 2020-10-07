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
    public class GroupsController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/Groups
        public List<GroupViewModel> GetGroups()
        {
            List<GroupViewModel> GroupList = new List<GroupViewModel>();

            foreach(Group incomingGroup in db.Groups)
            {
                GroupList.Add(new GroupViewModel(incomingGroup));
            }

            return GroupList;
        }

        // GET: api/Groups/5
        [ResponseType(typeof(GroupViewModel))]
        public async Task<IHttpActionResult> GetGroup(Guid id)
        {
            Group group = await db.Groups.FindAsync(id);
            if (group == null)
            {
                return NotFound();
            }

            return Ok(new GroupViewModel(group));
        }

        // PUT: api/Groups/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGroup(Guid id, Group group)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != group.id)
            {
                return BadRequest();
            }

            db.Entry(group).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupExists(id))
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

        // POST: api/Groups
        [ResponseType(typeof(GroupViewModel))]
        public async Task<IHttpActionResult> PostGroup(Group group)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Groups.Add(group);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GroupExists(group.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = group.id }, new GroupViewModel(group));
        }

        // DELETE: api/Groups/5
        [ResponseType(typeof(GroupViewModel))]
        public async Task<IHttpActionResult> DeleteGroup(Guid id)
        {
            Group group = await db.Groups.FindAsync(id);
            if (group == null)
            {
                return NotFound();
            }

            db.Groups.Remove(group);
            await db.SaveChangesAsync();

            return Ok(new GroupViewModel(group));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GroupExists(Guid id)
        {
            return db.Groups.Count(e => e.id == id) > 0;
        }
    }
}