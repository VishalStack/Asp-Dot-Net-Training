using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Book_MVCwebApp.Models
{
    public class Book
    {
        [Required(ErrorMessage = "Enter Book Id")]
        public int BookId { get; set; }
        [Required(ErrorMessage = "Enter Book Name")]
        public string BookName{ get; set; }
        [Required(ErrorMessage = " Enter Author Name")]
        public string AuthorName { get; set; }
        [Required(ErrorMessage = "Enter Book Description")]
        public string BookDescription { get; set; }

        public List<Book> GetBookData { get; set; }
    }
}