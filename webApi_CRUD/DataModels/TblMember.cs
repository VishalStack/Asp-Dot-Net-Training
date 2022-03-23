using System;
using System.Collections.Generic;

#nullable disable

namespace webApi_CRUD.DataModels
{
    public partial class TblMember
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
