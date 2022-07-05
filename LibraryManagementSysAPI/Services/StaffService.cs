using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Repositories;
namespace LibraryManagementSysAPI.Services
{
    public class StaffService : BaseService<Staff>, IService<Staff>
    {
        public StaffService(IRepository<Staff> repo) : base(repo) { }
    }
}
