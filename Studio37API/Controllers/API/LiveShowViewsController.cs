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
    public class LiveShowViewsController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/LiveShowViews
        public List<LiveShowViewViewModel> GetLiveShowViews()
        {
            List<LiveShowViewViewModel> LiveShowViewList = new List<LiveShowViewViewModel>();

            foreach(LiveShowView incomingLiveShowView in db.LiveShowViews)
            {
                LiveShowViewList.Add(new LiveShowViewViewModel(incomingLiveShowView));
            }

            return LiveShowViewList;
        }

        // GET: api/LiveShowViews/5
        [ResponseType(typeof(LiveShowViewViewModel))]
        public async Task<IHttpActionResult> GetLiveShowView(Guid id)
        {
            LiveShowView liveShowView = await db.LiveShowViews.FindAsync(id);
            if (liveShowView == null)
            {
                return NotFound();
            }

            return Ok(new LiveShowViewViewModel(liveShowView));
        }

        // PUT: api/LiveShowViews/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLiveShowView(Guid id, LiveShowView liveShowView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != liveShowView.id)
            {
                return BadRequest();
            }

            db.Entry(liveShowView).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LiveShowViewExists(id))
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

        // POST: api/LiveShowViews
        [ResponseType(typeof(LiveShowViewViewModel))]
        public async Task<IHttpActionResult> PostLiveShowView(LiveShowView liveShowView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LiveShowViews.Add(liveShowView);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LiveShowViewExists(liveShowView.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = liveShowView.id }, new LiveShowViewViewModel(liveShowView));
        }

        // DELETE: api/LiveShowViews/5
        [ResponseType(typeof(LiveShowViewViewModel))]
        public async Task<IHttpActionResult> DeleteLiveShowView(Guid id)
        {
            LiveShowView liveShowView = await db.LiveShowViews.FindAsync(id);
            if (liveShowView == null)
            {
                return NotFound();
            }

            db.LiveShowViews.Remove(liveShowView);
            await db.SaveChangesAsync();

            return Ok(new LiveShowViewViewModel(liveShowView));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LiveShowViewExists(Guid id)
        {
            return db.LiveShowViews.Count(e => e.id == id) > 0;
        }
    }
}