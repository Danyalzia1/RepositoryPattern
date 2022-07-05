using LibraryManagementSysAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : BaseController<Member>
    {
        public MemberController(Repositories.IRepository<Member> irepository) : base(irepository)
        {
        }
    }
}
