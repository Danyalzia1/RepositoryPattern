using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Repositories;

namespace LibraryManagementSysAPI.Services
{
    public class MembershipService : BaseService<Membership>, IService<Membership>
    {
        public MembershipService(IRepository<Membership> repo) : base(repo)
        {
        }
    }
}
