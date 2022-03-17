using MvcWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcWebApi.Controllers
{
    public class ClientApiController : ApiController
    {
        ExamEntities db = new ExamEntities();
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetClients()
        {
            List<Client> list = db.Clients.ToList();
            return Ok(list);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetClientById(int id)
        {
            var cli = db.Clients.Where(model => model.ClientId == id).FirstOrDefault();
            return Ok(cli);
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult ClientInsert(Client c)
        {
            db.Clients.Add(c);
            db.SaveChanges();
            return Ok();
        }

        [System.Web.Http.HttpPut]
        public IHttpActionResult ClientUpdate(Client c)
        {
            var cli = db.Clients.Where(model => model.ClientId == c.ClientId).FirstOrDefault();
            if(cli != null)
            {
                cli.ClientId = c.ClientId;
                cli.ClientName= c.ClientName;
                cli.MobNo = c.MobNo;
                cli.EmailId = c.EmailId;
                db.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }


        [System.Web.Http.HttpDelete]
        public IHttpActionResult ClientDelete(int id)
        {
            var cli = db.Clients.Where(model => model.ClientId == id).FirstOrDefault();
            db.Entry(cli).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok();
        }
    }
}
