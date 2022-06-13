using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSys.Models;

namespace LibraryManagementSys.Repositories
{
    public class LibaryRepository : BaseRepository<Library>
    {
        List<Library> libraryList = new List<Library>() { 
        new Library{Id=1,Name="Allama Iqbal Libaray"},
        };


        public LibaryRepository(LibraryDbContext db) : base(db)
        {

        }
    }
}
