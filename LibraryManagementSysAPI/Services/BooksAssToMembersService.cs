using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Repositories;

namespace LibraryManagementSysAPI.Services
{
    public class BooksAssToMembersService : BaseService<BooksAssToMembers>, IService<BooksAssToMembers>
    {
        public BooksAssToMembersService(IRepository<BooksAssToMembers> repo) : base(repo)
        {
        }

    }
}