using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Repositories;

namespace LibraryManagementSysAPI.Services
{
    public class BookService : BaseService<Book>, IService<Book>
    {
        public BookService(IRepository<Book> repo): base(repo) 
        {
        }
    }
}
