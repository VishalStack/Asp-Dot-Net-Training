using System;
using System.Collections.Generic;

#nullable disable

namespace webApi_CRUD.DataModels
{
    public partial class EmpTable
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal? EmployeeSalary { get; set; }
        public string EmployeeCity { get; set; }
    }
}
