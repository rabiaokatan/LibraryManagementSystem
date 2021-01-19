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

        [StringLength(13, MinimumLength = 13, ErrorMessage = "ISBN must be 13 characters")]
        public int  ISBN { get; set; }

        public string BookShelf { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }
        public BookGenre BookGenre { get; set; }
    }
}
