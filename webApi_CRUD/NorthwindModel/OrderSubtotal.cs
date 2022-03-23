using System;
using System.Collections.Generic;

#nullable disable

namespace webApi_CRUD.NorthwindModel
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
