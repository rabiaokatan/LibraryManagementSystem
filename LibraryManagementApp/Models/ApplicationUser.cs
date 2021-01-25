using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApp.Models
{
    public class ApplicationUser
    {
        [NotMapped]
        public bool IsAdmin { get; set; }
    }
}
