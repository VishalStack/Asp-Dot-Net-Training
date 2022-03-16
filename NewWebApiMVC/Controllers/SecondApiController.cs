using NewWebApiMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewWebApiMVC.Controllers
{
    public class SecondApiController : ApiController
    {
        ProductClientEntities db = new ProductClientEntities();

        [HttpGet]
        public IHttpActionResult Action()
        {
            List<Client> obj = db.Clients.ToList();
            return Ok(obj);
        }

        [HttpGet]
        public IHttpActionResult Action(int id)
        {
            var obj = db.Clients.Where(model => model.ClientId == id).FirstOrDefault();
            return Ok(obj);
        }


        [HttpPost]
        public IHttpActionResult CliInsert(Client c)
        {
            db.Clients.Add(c);
            db.SaveChanges();
            return Ok();
        }


        [HttpPut]
        public IHttpActionResult CliUpdate(Client c)
        {
            var cli = db.Clients.Where(model => model.ClientId == c.ClientId).FirstOrDefault();
            if (cli != null)
            {
                cli.ClientId = c.ClientId;
                cli.ClientName = c.ClientName;
                cli.MobileNo = c.MobileNo;
                cli.EmailId = c.EmailId;
                db.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult CliDelete(int id)
        {
            var obj = db.Clients.Where(model => model.ClientId == id).FirstOrDefault();
            db.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok(obj);

        }

    }
}
