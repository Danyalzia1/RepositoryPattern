using LibraryManagementSysAPI.Data;
using LibraryManagementSysAPI.Models;


namespace LibraryManagementSysAPI.Repositories
{
    public class MembershipRepository : BaseRepository<Membership>
    {



        public MembershipRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
