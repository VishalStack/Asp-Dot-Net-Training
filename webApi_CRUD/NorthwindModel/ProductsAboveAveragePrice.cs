using System;
using System.Collections.Generic;

#nullable disable

namespace webApi_CRUD.NorthwindModel
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
