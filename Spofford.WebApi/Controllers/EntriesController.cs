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
using Spofford.Core.Domain;
using Spofford.Data.Context;

namespace Spofford.WebApi.Controllers
{
    public class EntriesController : ApiController
    {
        private SpoffordDbContext db = new SpoffordDbContext();

        // GET: api/Entries
        public IQueryable<Entry> GetEntries()
        {
            return db.Entries;
        }

        // GET: api/Entries/5
        [ResponseType(typeof(Entry))]
        public IHttpActionResult GetEntry(int id)
        {
            Entry entry = db.Entries.Find(id);
            if (entry == null)
            {
                return NotFound();
            }

            return Ok(entry);
        }

        // PUT: api/Entries/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEntry(int id, Entry entry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != entry.EntryID)
            {
                return BadRequest();
            }

            db.Entry(entry).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntryExists(id))
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

        // http://stackoverflow.com/questions/14098600/many-to-many-relationships-not-saving
        // POST: api/Entries
        [ResponseType(typeof(Entry))]
        public IHttpActionResult PostEntry(EntryCreateViewModel vm)
        {
            var entry = AutoMapper.Mapper.Map<EntryCreateViewModel, Entry>(vm);

            db.Players.Attach(entry.Player);

            foreach (var team in entry.Teams)
            {
                db.Teams.Attach(team);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Entries.Add(entry);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = entry.EntryID }, entry);
        }

        // DELETE: api/Entries/5
        [ResponseType(typeof(Entry))]
        public IHttpActionResult DeleteEntry(int id)
        {
            Entry entry = db.Entries.Find(id);
            if (entry == null)
            {
                return NotFound();
            }

            db.Entries.Remove(entry);
            db.SaveChanges();

            return Ok(entry);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EntryExists(int id)
        {
            return db.Entries.Count(e => e.EntryID == id) > 0;
        }
    }
}