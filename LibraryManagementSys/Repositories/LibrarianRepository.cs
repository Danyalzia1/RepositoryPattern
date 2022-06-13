using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSys.Models;

namespace LibraryManagementSys.Repositories
{
    public class LibrarianRepository :BaseRepository<Librarian>
    {
        List<Librarian> _librarianList=new List<Librarian>() { 
            new Librarian { Id=1,Name="Sallar",ContactNo="03323256548",LibraryID=1},
        };

        public LibrarianRepository(LibraryDbContext db) : base(db)
        {


        }
    }
}
