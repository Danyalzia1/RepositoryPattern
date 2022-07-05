using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Repositories;

namespace LibraryManagementSysAPI.Services
{
    public class LibrarianService : BaseService<Librarian>, IService<Librarian>
    {
        public LibrarianService(IRepository<Librarian> repo) : base(repo)
        {
        }
    }
}
