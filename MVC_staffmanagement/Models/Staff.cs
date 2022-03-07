using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_staffmanagement.Models
{
    public class Staff
    {
        [Required(ErrorMessage = "ID is required.")]
        public int id { get; set; }
        [Required(ErrorMessage = "Full Name is required.")]
        public string fullName { get; set; }
        [Required(ErrorMessage = "Date Of Birth is required.")]
        public DateTime dob { get; set; }
        [Required(ErrorMessage = "Mobile no is required.")]
        public string mob { get; set; }
        [Required(ErrorMessage = "mail id is required.")]
        public string mailid { get; set; }
        [Required(ErrorMessage = "gender is required.")]
        public string gender { get; set; }
        public List<Staff> ShowStaffList { get; set; }

    }
}