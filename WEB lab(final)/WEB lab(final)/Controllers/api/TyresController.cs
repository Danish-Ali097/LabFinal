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
using WEB_lab_final_.DataAccessLayer;
using WEB_lab_final_.Models;

namespace WEB_lab_final_.Controllers
{
    public class TyresController : ApiController
    {
        private DBContext db = new DBContext();

        // GET: api/Tyres
        public IQueryable<Tyres> Gettyres()
        {
            return db.Tyres;
        }

        // GET: api/Tyres/5
        [ResponseType(typeof(Tyres))]
        public IHttpActionResult GetTyres(int id)
        {
            Tyres tyres = db.Tyres.Find(id);
            if (tyres == null)
            {
                return NotFound();
            }

            return Ok(tyres);
        }

        // PUT: api/Tyres/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTyres(int id, Tyres tyres)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tyres.TyreId)
            {
                return BadRequest();
            }

            db.Entry(tyres).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TyresExists(id))
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

        // POST: api/Tyres
        [ResponseType(typeof(Tyres))]
        public IHttpActionResult PostTyres(Tyres tyres)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tyres.Add(tyres);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tyres.TyreId }, tyres);
        }

        // DELETE: api/Tyres/5
        [ResponseType(typeof(Tyres))]
        public IHttpActionResult DeleteTyres(int id)
        {
            Tyres tyres = db.Tyres.Find(id);
            if (tyres == null)
            {
                return NotFound();
            }

            db.Tyres.Remove(tyres);
            db.SaveChanges();

            return Ok(tyres);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TyresExists(int id)
        {
            return db.Tyres.Count(e => e.TyreId == id) > 0;
        }
    }
}