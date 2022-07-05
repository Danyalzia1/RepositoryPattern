using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Repositories;

namespace LibraryManagementSysAPI.Services
{
    public class MemberService : BaseService<Member>, IService<Member>
    {
        public MemberService(IRepository<Member> repo) : base(repo)
        {
        }
    }
}
