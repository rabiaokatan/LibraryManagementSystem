using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        //[StringLength(18, MinimumLength = 13, ErrorMessage = "ISBN must be 13 characters")]
        //[RegularExpression("([0-9]{10}|[0-9]{13})", ErrorMessage = "Invalid ISBN")]
        public string ISBN { get; set; }

        [Display(Name = "Book Shelf")]
        public string BookShelf { get; set; }

        [Display(Name ="Author")]
        public int AuthorId { get; set; }

        public Author Author { get; set; }

        [Display(Name = "Book Genre")]
        public BookGenre BookGenre { get; set; }
    }
}
