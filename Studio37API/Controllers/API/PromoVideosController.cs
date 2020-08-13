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

namespace Studio37API.Controllers.API
{
    public class PromoVideosController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/PromoVideos
        public IQueryable<PromoVideo> GetPromoVideos()
        {
            return db.PromoVideos;
        }

        // GET: api/PromoVideos/5
        [ResponseType(typeof(PromoVideo))]
        public async Task<IHttpActionResult> GetPromoVideo(Guid id)
        {
            PromoVideo promoVideo = await db.PromoVideos.FindAsync(id);
            if (promoVideo == null)
            {
                return NotFound();
            }

            return Ok(promoVideo);
        }

        // PUT: api/PromoVideos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPromoVideo(Guid id, PromoVideo promoVideo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != promoVideo.id)
            {
                return BadRequest();
            }

            db.Entry(promoVideo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PromoVideoExists(id))
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

        // POST: api/PromoVideos
        [ResponseType(typeof(PromoVideo))]
        public async Task<IHttpActionResult> PostPromoVideo(PromoVideo promoVideo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PromoVideos.Add(promoVideo);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PromoVideoExists(promoVideo.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = promoVideo.id }, promoVideo);
        }

        // DELETE: api/PromoVideos/5
        [ResponseType(typeof(PromoVideo))]
        public async Task<IHttpActionResult> DeletePromoVideo(Guid id)
        {
            PromoVideo promoVideo = await db.PromoVideos.FindAsync(id);
            if (promoVideo == null)
            {
                return NotFound();
            }

            db.PromoVideos.Remove(promoVideo);
            await db.SaveChangesAsync();

            return Ok(promoVideo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PromoVideoExists(Guid id)
        {
            return db.PromoVideos.Count(e => e.id == id) > 0;
        }
    }
}