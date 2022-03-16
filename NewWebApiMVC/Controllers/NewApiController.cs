using NewWebApiMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewWebApiMVC.Controllers
{
    public class NewApiController : ApiController
    {
        ProductClientEntities db = new ProductClientEntities();

        [HttpGet]
        public IHttpActionResult Action()
        { 
            List<Product> obj = db.Products.ToList();
            return Ok(obj);
        }

        [HttpGet]
        public IHttpActionResult Action(int id)
        {
            var obj = db.Products.Where(model => model.ProductId==id).FirstOrDefault();
            return Ok(obj);
        }

        [HttpPost]
        public IHttpActionResult ProInsert(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult ProUpdate(Product p)
        {
            var pro= db.Products.Where(model => model.ProductId == p.ProductId).FirstOrDefault();
            if( pro != null)
            {
                pro.ProductId = p.ProductId;
                pro.ProductName = p.ProductName;
                pro.Quantity = p.Quantity;
                pro.Price = p.Price;
                db.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult ProDelete(int id)
        {
            var obj = db.Products.Where(model => model.ProductId == id).FirstOrDefault();
            db.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok(obj);
            
        }



        }
    }
 