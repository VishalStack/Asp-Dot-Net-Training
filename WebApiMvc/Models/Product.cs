using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiMvc.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
    }
}