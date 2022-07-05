using LibraryManagementSysAPI.Data;
using LibraryManagementSysAPI.Models;

namespace LibraryManagementSysAPI.Repositories
{
    public class BooksAssToMembersRepository : BaseRepository<BooksAssToMembers>
    {





        public BooksAssToMembersRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
