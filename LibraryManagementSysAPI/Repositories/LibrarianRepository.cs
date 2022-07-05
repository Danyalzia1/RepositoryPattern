using System.Collections.Generic;
using LibraryManagementSysAPI.Data;
using LibraryManagementSysAPI.Models;
namespace LibraryManagementSysAPI.Repositories
{
    public class LibrarianRepository : BaseRepository<Librarian>
    {
        /*List<Librarian> _librarianList = new List<Librarian>() {
            new Librarian { Id=1,Name="Sallar",ContactNo="03323256548",LibraryID=1},
        };*/

        public LibrarianRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
