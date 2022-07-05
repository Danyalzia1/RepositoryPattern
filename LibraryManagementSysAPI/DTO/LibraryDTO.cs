using LibraryManagementSysAPI.Models;
using System.Collections.Generic;

namespace LibraryManagementSysAPI.DbModels
{
    public class LibraryDTO
    {
        public int Id { get; set; }
       
        public string Name { get; set; }

        public ICollection<Librarian> Librarians { get; set; }

        public ICollection<Book> Books { get; set; }
        public ICollection<Membership> Memberships { get; set; }
    }
}
