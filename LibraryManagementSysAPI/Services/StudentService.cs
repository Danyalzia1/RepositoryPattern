using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Repositories;

namespace LibraryManagementSysAPI.Services
{
    public class StudentService : BaseService<Student>, IService<Student>
    {
        public StudentService(IRepository<Student> repo) : base(repo)
        {
        }
    }
}
