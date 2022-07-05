using LibraryManagementSysAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSysAPI.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CRKRL-ZIAAADAN1\\SQLEXPRESS;Database=LMS;Trusted_Connection=True;");
        }

        public DbSet<Book> Book { get; set;} 
        public DbSet<Librarian> Librarian { get; set; }
        public DbSet<Library> Library { get; set; }

        public DbSet<Member> Member { get; set; }

        public DbSet<Membership> Membership { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Student { get; set; }

        public DbSet<BooksAssToMembers> BookAssToMembers { get; set; }


    }
}
