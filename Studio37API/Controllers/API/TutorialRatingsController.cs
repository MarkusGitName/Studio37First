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
    public class TutorialRatingsController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/TutorialRatings
        public List<TutorialRatingViewModel> GetTutorialRatings()
        {
            List<TutorialRatingViewModel> TutorialRatingList = new List<TutorialRatingViewModel>();

            foreach(TutorialRating incomingTutorialRating in db.TutorialRatings)
            {
                TutorialRatingList.Add(new TutorialRatingViewModel(incomingTutorialRating));
            }

            return TutorialRatingList;
        }

        // GET: api/TutorialRatings/5
        [ResponseType(typeof(TutorialRatingViewModel))]
        public async Task<IHttpActionResult> GetTutorialRating(Guid id)
        {
            TutorialRating tutorialRating = await db.TutorialRatings.FindAsync(id);
            if (tutorialRating == null)
            {
                return NotFound();
            }

            return Ok(new TutorialRatingViewModel(tutorialRating));
        }

        // PUT: api/TutorialRatings/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTutorialRating(Guid id, TutorialRating tutorialRating)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tutorialRating.id)
            {
                return BadRequest();
            }

            db.Entry(tutorialRating).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorialRatingExists(id))
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

        // POST: api/TutorialRatings
        [ResponseType(typeof(TutorialRatingViewModel))]
        public async Task<IHttpActionResult> PostTutorialRating(TutorialRating tutorialRating)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TutorialRatings.Add(tutorialRating);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TutorialRatingExists(tutorialRating.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tutorialRating.id }, new TutorialRatingViewModel(tutorialRating));
        }

        // DELETE: api/TutorialRatings/5
        [ResponseType(typeof(TutorialRatingViewModel))]
        public async Task<IHttpActionResult> DeleteTutorialRating(Guid id)
        {
            TutorialRating tutorialRating = await db.TutorialRatings.FindAsync(id);
            if (tutorialRating == null)
            {
                return NotFound();
            }

            db.TutorialRatings.Remove(tutorialRating);
            await db.SaveChangesAsync();

            return Ok(new TutorialRatingViewModel(tutorialRating));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TutorialRatingExists(Guid id)
        {
            return db.TutorialRatings.Count(e => e.id == id) > 0;
        }
    }
}