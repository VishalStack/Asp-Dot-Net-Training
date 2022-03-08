using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace code4.Models
{
    public class StaffModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Fullname is required.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "DOB is required.")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "MobNo is required.")]
        public int MobNo { get; set; }

        [Required(ErrorMessage = "EmailId is required.")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        public List<StaffModel> GetStaff { get; set; }

    }
}