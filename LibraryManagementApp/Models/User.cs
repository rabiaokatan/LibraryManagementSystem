﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApp.Models
{
    public class User: IdentityUser
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        [Display(Name ="Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

       /* [EmailAddress(ErrorMessage ="{0} invalid e-mail address")]
        public string Email { get; set; }*/
    }
}
