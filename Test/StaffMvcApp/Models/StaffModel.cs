using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StaffMvcApp.Models
{
    public class StaffModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Full name is required.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "DoB is required.")]
        public DateTime DoB { get; set; }

        [Required(ErrorMessage = "MobNo is required.")]
        public int MobNo { get; set; }

        [Required(ErrorMessage = "Email Id name is required.")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        List<StaffModel> GetStaff { get; set; }

    }
}
