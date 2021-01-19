using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApp.Models
{
    public class BookRequest
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Book Title")]
        public string BookTitle { get; set; }

        [Required]
        [Display(Name = "Author Name")]
        public string AuthorName { get; set; }

        [Required]
        [Display(Name = "Author Surname")]
        public string AuthorSurname { get; set; }
    }
}
