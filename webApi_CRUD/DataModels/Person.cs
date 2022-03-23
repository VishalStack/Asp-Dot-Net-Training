using System;
using System.Collections.Generic;

#nullable disable

namespace webApi_CRUD.DataModels
{
    public partial class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int DeptId { get; set; }
        public int ExpId { get; set; }
    }
}
