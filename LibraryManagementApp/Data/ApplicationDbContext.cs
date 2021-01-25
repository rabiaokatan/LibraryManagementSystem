using LibraryManagementApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookRequest> BookRequests { get; set; }
        public DbSet<LibraryManagementApp.Models.Author> Author_1 { get; set; }
        public DbSet<LibraryManagementApp.Models.ProjectRole> ProjectRole { get; set; }
    }
}
