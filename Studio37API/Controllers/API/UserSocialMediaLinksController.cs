﻿using System;
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
    public class UserSocialMediaLinksController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/UserSocialMediaLinks
        public List<UserSocialMediaLinkViewModel> GetUserSocialMediaLinks()
        {
            List<UserSocialMediaLinkViewModel> UserSocialMediaLinkList = new List<UserSocialMediaLinkViewModel>();

            foreach(UserSocialMediaLink incomingUserSocialMediaLink in db.UserSocialMediaLinks)
            {
                UserSocialMediaLinkList.Add(new UserSocialMediaLinkViewModel(incomingUserSocialMediaLink));
            }

            return UserSocialMediaLinkList;
        }

        // GET: api/UserSocialMediaLinks/5
        [ResponseType(typeof(UserSocialMediaLinkViewModel))]
        public async Task<IHttpActionResult> GetUserSocialMediaLink(Guid id)
        {
            UserSocialMediaLink userSocialMediaLink = await db.UserSocialMediaLinks.FindAsync(id);
            if (userSocialMediaLink == null)
            {
                return NotFound();
            }

            return Ok(new UserSocialMediaLinkViewModel(userSocialMediaLink));
        }

        // PUT: api/UserSocialMediaLinks/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUserSocialMediaLink(Guid id, UserSocialMediaLink userSocialMediaLink)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userSocialMediaLink.id)
            {
                return BadRequest();
            }

            db.Entry(userSocialMediaLink).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserSocialMediaLinkExists(id))
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

        // POST: api/UserSocialMediaLinks
        [ResponseType(typeof(UserSocialMediaLinkViewModel))]
        public async Task<IHttpActionResult> PostUserSocialMediaLink(UserSocialMediaLink userSocialMediaLink)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserSocialMediaLinks.Add(userSocialMediaLink);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserSocialMediaLinkExists(userSocialMediaLink.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = userSocialMediaLink.id }, new UserSocialMediaLinkViewModel(userSocialMediaLink));
        }

        // DELETE: api/UserSocialMediaLinks/5
        [ResponseType(typeof(UserSocialMediaLinkViewModel))]
        public async Task<IHttpActionResult> DeleteUserSocialMediaLink(Guid id)
        {
            UserSocialMediaLink userSocialMediaLink = await db.UserSocialMediaLinks.FindAsync(id);
            if (userSocialMediaLink == null)
            {
                return NotFound();
            }

            db.UserSocialMediaLinks.Remove(userSocialMediaLink);
            await db.SaveChangesAsync();

            return Ok(new UserSocialMediaLinkViewModel(userSocialMediaLink));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserSocialMediaLinkExists(Guid id)
        {
            return db.UserSocialMediaLinks.Count(e => e.id == id) > 0;
        }
    }
}