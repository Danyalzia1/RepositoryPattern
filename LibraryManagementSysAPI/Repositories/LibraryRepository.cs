using System.Collections.Generic;
using LibraryManagementSysAPI.Data;
using LibraryManagementSysAPI.Models;

namespace LibraryManagementSysAPI.Repositories
{
    public class LibraryRepository : BaseRepository<Library>
    {
        /*List<Library> libraryList = new List<Library>() {
        new Library{Id=1,Name="Allama Iqbal Libaray"},
        };*/


        public LibraryRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
