using LibraryManagementSys.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys
{
    public class LibraryDbContext:DbContext
    {
        public LibraryDbContext() : base("name=LibraryDbContext")
        {
        }

        public  DbSet<Book> Book { get; set; }
         public  DbSet<Librarian> Librarian { get; set; }
         public DbSet<Library> Libarary { get; set; }

        public DbSet<Member> Member { get; set; }

        public DbSet<Membership> Membership { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Student { get; set; }


        

    }
}
