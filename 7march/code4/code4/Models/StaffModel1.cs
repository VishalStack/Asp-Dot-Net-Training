//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Web;

using System;

namespace StaffMvcApp.Models
{
    public class StaffModel
    {
        public string Gender { get; internal set; }
        public string EmailId { get; internal set; }
        public int MobNo { get; internal set; }
        public DateTime DOB { get; internal set; }
        public string FullName { get; internal set; }
        public int Id { get; internal set; }
    }
}