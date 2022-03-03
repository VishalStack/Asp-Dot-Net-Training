using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_cutomerApp.Models
{
    public class Customer
    {
        [Key]
        public int customerId { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Enter Address")]
        public string add { get; set; }

        [Required(ErrorMessage = "Enter Mobileno")]
        public string mno { get; set; }

        [DataType(DataType.Date)]

        [Required(ErrorMessage = "Enter Birthdate")]
        public DateTime bdate { get; set; }

        [Required(ErrorMessage = "Enter EmailID")]
        public string mailid { get; set; }

        public List<Customer> ShowallCustomer { get; set; }
    }
}