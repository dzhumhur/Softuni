using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Messages.Data;
using Messages.Data.Models;

namespace Messages.RestServices.Controllers
{
    using ViewModels;

    public class ChannelsController : ApiController
    {
        private MessagesDbContext db = new MessagesDbContext();

        // GET: api/Channels
        public IQueryable<ChannelViewModel> GetChannels()
        {
            return db.Channels.OrderBy(c => c.Name).Select(c => new ChannelViewModel()
            {
                Id =  c.Id,
                Name = c.Name
            });
        }

        // GET: api/Channels/5
        [ResponseType(typeof(ChannelViewModel))]
        public IHttpActionResult GetChannel(int id)
        {
            Channel channel = db.Channels.Find(id);
            if (channel == null)
            {
                return NotFound();
            }

            return Ok(new ChannelViewModel()
            {
                Id = channel.Id,
                Name = channel.Name
            });
        }

        // PUT: api/Channels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutChannel(int id, Channel channel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != channel.Id)
            {
                return BadRequest();
            }

            //db.Entry(channel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChannelExists(id))
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

        // POST: api/Channels
        [ResponseType(typeof(ChannelViewModel))]
        public IHttpActionResult PostChannel(Channel channel)
        {
            if (channel == null)
            {
                return this.BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (db.Channels.Any(c => c.Name.Equals(channel.Name)))
            {
                return this.Conflict();
            }


            db.Channels.Add(channel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = channel.Id }, new ChannelViewModel()
            {
                Id = channel.Id,
                Name = channel.Name
            });
        }

        // DELETE: api/Channels/5
        [ResponseType(typeof(Channel))]
        public IHttpActionResult DeleteChannel(int id)
        {
            Channel channel = db.Channels.Find(id);

            if (channel == null)
            {
                return NotFound();
            }

            if (channel.ChannelMessages.Any())
            {
                return this.Conflict();
            }

            db.Channels.Remove(channel);
            db.SaveChanges();

            return Ok(channel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ChannelExists(int id)
        {
            return db.Channels.Count(e => e.Id == id) > 0;
        }
    }
}