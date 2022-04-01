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
using ExceptionHandlingWebApi.Models;

namespace ExceptionHandlingWebApi.Controllers
{
    public class MembersController : ApiController
    {
        private MemberDBEntities db = new MemberDBEntities();

        // GET: api/Members
        public IQueryable<tblMember> GettblMembers()
        {
            return db.tblMembers;
        }

        // GET: api/Members/5
        [ResponseType(typeof(tblMember))]
        public IHttpActionResult GettblMember(int id)
        {
            tblMember tblMember = db.tblMembers.Find(id);
            if (tblMember == null)
            {
                var msg = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("Sorry!!! Your search id {0} is not avaliable here.", id)),
                    ReasonPhrase = "Member not found"
                };

                throw new HttpResponseException(msg);
            }
            return Ok(tblMember);
        }

        // PUT: api/Members/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblMember(int id, tblMember tblMember)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblMember.MemberID)
            {
                return BadRequest();
            }

            db.Entry(tblMember).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblMemberExists(id))
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

        // POST: api/Members
        [ResponseType(typeof(tblMember))]
        public IHttpActionResult PosttblMember(tblMember tblMember)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblMembers.Add(tblMember);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblMember.MemberID }, tblMember);
        }

        // DELETE: api/Members/5
        [ResponseType(typeof(tblMember))]
        public IHttpActionResult DeletetblMember(int id)
        {
            tblMember tblMember = db.tblMembers.Find(id);
            if (tblMember == null)
            {
                return NotFound();
            }

            db.tblMembers.Remove(tblMember);
            db.SaveChanges();

            return Ok(tblMember);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblMemberExists(int id)
        {
            return db.tblMembers.Count(e => e.MemberID == id) > 0;
        }
    }
}