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
    public class ChatsController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/Chats
        public List<ChatViewModel> GetChats()
        {
            List<ChatViewModel> ChatyList = new List<ChatViewModel>();
            foreach(Chat incomingChat in  db.Chats)
            {
                ChatyList.Add(new ChatViewModel(incomingChat));
            }
            return ChatyList;
        }

        // GET: api/Chats/5
        [ResponseType(typeof(ChatViewModel))]
        public async Task<IHttpActionResult> GetChat(Guid id)
        {
            Chat chat = await db.Chats.FindAsync(id);
            if (chat == null)
            {
                return NotFound();
            }

            return Ok(new ChatViewModel(chat));
        }

        // PUT: api/Chats/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutChat(Guid id, Chat chat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != chat.ChatID)
            {
                return BadRequest();
            }

            db.Entry(chat).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChatExists(id))
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

        // POST: api/Chats
        [ResponseType(typeof(ChatViewModel))]
        public async Task<IHttpActionResult> PostChat(Chat chat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Chats.Add(chat);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChatExists(chat.ChatID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = chat.ChatID }, new ChatViewModel(chat));
        }

        // DELETE: api/Chats/5
        [ResponseType(typeof(ChatViewModel))]
        public async Task<IHttpActionResult> DeleteChat(Guid id)
        {
            Chat chat = await db.Chats.FindAsync(id);
            if (chat == null)
            {
                return NotFound();
            }

            db.Chats.Remove(chat);
            await db.SaveChangesAsync();

            return Ok(new ChatViewModel(chat));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ChatExists(Guid id)
        {
            return db.Chats.Count(e => e.ChatID == id) > 0;
        }
    }
}