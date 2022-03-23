using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using webApi_CRUD.Entities;
using webApi_CRUD.NorthwindModel;

namespace webApi_CRUD.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class NortwindController : ControllerBase
    {
        //--------------------Using Paging-----------------------
        [HttpGet]
        [Route("GetOrdersEF")]

        public List<Order> GetOrdersEF([FromQuery] Pagination @params)
        {
            NorthwindContext nc = new NorthwindContext();

            var orders= nc.Orders;


            var paginationMetaData = new PaginationMetaData(orders.Count(), @params.Page, @params.ItemsPerPage);
            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(paginationMetaData));

            var items = orders.Skip((@params.Page - 1) * @params.ItemsPerPage).Take(@params.ItemsPerPage).ToList();

            return items;
        }

        



        [HttpGet]
        [Route("GetOrdersByIdEF")]

        public List<Order> GetOrdersByIdEF(int id)
        {
            NorthwindContext nc = new NorthwindContext();

            return nc.Orders.Where(e => e.OrderId == id).ToList();

        }

        [HttpGet]
        [Route("GetCustomersEF")]

        public List<Customer> GetCustomersEF(string sort)
        {
            NorthwindContext nc = new NorthwindContext();
            
            if (sort == "id")
            {
                return nc.Customers.OrderBy(p => p.CustomerId).ToList();   
            }
            else if(sort=="company")
            {
                return nc.Customers.OrderBy(p => p.CompanyName).ToList();
            }
            else if (sort == "contact")
            {
                return nc.Customers.OrderBy(p => p.ContactName).ToList();
            }
            else
            {
                return nc.Customers.ToList();
            }
            

        }

        //----------------Using Filters------------------

        [HttpGet]
        [Route("GetProductsEF")]

        public List<Product> GetProductsEF([FromQuery]string product,[FromQuery] int categoryid)
        {
            NorthwindContext nc = new NorthwindContext();


            var pro = nc.Products.ToList();


            if (string.IsNullOrWhiteSpace(product) && categoryid != 0)
            {
                return pro;
            }
            var collection = nc.Products as IQueryable<Product>;

            if(!string.IsNullOrWhiteSpace(product))
            {
                product = product.Trim();
                collection = collection.Where(b => b.ProductName.Contains(product));
            }
            if (categoryid != 0)
            {
                
                collection = collection.Where(b => b.CategoryId == categoryid);
            }

            return collection.ToList();

        }

    }
}
