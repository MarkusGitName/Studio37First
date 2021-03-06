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
    public class PostCattegoriesController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/PostCattegories
        public List<PostCattegoryViewModel> GetPostCattegories()
        {
            List<PostCattegoryViewModel> PostCattegoryList = new List<PostCattegoryViewModel>();

            foreach(PostCattegory incomingPostCattegory in db.PostCattegories)
            {
                PostCattegoryList.Add(new PostCattegoryViewModel(incomingPostCattegory));
            }

            return PostCattegoryList;
        }

        // GET: api/PostCattegories/5
        [ResponseType(typeof(PostCattegoryViewModel))]
        public async Task<IHttpActionResult> GetPostCattegory(Guid id)
        {
            PostCattegory postCattegory = await db.PostCattegories.FindAsync(id);
            if (postCattegory == null)
            {
                return NotFound();
            }

            return Ok(new PostCattegoryViewModel(postCattegory));
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
        [ResponseType(typeof(PostCattegoryViewModel))]
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

            return CreatedAtRoute("DefaultApi", new { id = postCattegory.id }, new PostCattegoryViewModel(postCattegory));
        }

        // DELETE: api/PostCattegories/5
        [ResponseType(typeof(PostCattegoryViewModel))]
        public async Task<IHttpActionResult> DeletePostCattegory(Guid id)
        {
            PostCattegory postCattegory = await db.PostCattegories.FindAsync(id);
            if (postCattegory == null)
            {
                return NotFound();
            }

            db.PostCattegories.Remove(postCattegory);
            await db.SaveChangesAsync();

            return Ok(new PostCattegoryViewModel(postCattegory));
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