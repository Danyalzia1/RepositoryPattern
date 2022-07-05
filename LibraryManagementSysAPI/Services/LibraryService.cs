using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Repositories;

namespace LibraryManagementSysAPI.Services
{
    public class LibraryService : BaseService<Library>, IService<Library>
    {
        public LibraryService(IRepository<Library> repo) : base(repo)
        {
        }
    }
}
