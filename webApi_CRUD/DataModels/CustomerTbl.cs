using System;
using System.Collections.Generic;

#nullable disable

namespace webApi_CRUD.DataModels
{
    public partial class CustomerTbl
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
