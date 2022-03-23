using System;
using System.Collections.Generic;

#nullable disable

namespace webApi_CRUD.DataModels
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Add { get; set; }
        public string Mno { get; set; }
        public DateTime Bdate { get; set; }
        public string Mailid { get; set; }
    }
}
