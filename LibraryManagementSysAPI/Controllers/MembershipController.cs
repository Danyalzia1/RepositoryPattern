using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipController : BaseController<Membership>
    {
        public MembershipController(IRepository<Membership> irepository) : base(irepository)
        {
        }
    }
}
