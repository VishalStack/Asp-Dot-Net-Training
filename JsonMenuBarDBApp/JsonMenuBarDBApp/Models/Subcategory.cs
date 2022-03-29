using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonMenuBarDBApp.Models
{
    public class Subcategory
    {
        public int Subcat_id { get; set; }
        public int Cat_id { get; set; }
        public string Subcat_name { get; set; }
    }
}