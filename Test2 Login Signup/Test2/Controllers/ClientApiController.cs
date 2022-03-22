using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test2.Models;

namespace Test2.Controllers
{
    public class ClientApiController : ApiController
    {
        Test2DBEntities db = new Test2DBEntities();
        [HttpGet]
        public IHttpActionResult GetClient()
        {
           List<Client> list = db.Clients.ToList();
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult GetClientById(int id)
        {
            var cli = db.Clients.Where(Models => Models.ClientId == id).FirstOrDefault();
            return Ok(cli);
        }

        [HttpPost]
        public IHttpActionResult Clientinsert(Client e)
        {
           db.Clients.Add(e);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Clientupdate(Client e)
        {
            //db.Entry(e).State=System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();
            var cli = db.Clients.Where(Models=>Models.ClientId == e.ClientId).FirstOrDefault();
            if(cli != null)
            {
                cli.ClientId = e.ClientId;
                cli.ClientName = e.ClientName;
                cli.MobNo = e.MobNo;
                cli.EmailId = e.EmailId;
                db.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ClientDelete(int id)
        {
            var cli = db.Clients.Where(model => model.ClientId == id).FirstOrDefault();
            db.Entry(cli).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok();
        }


    }
}
