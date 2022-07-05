using LibraryManagementSysAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : BaseController<Staff>
    {
        public StaffController(Repositories.IRepository<Staff> irepository) : base(irepository)
        {
        }
    }
}
