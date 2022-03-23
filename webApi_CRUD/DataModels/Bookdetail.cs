using System;
using System.Collections.Generic;

#nullable disable

namespace webApi_CRUD.DataModels
{
    public partial class Bookdetail
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string BookDescription { get; set; }
    }
}
