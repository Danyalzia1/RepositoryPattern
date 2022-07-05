using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksAssToMembersController : BaseController<BooksAssToMembers>
    {
        public BooksAssToMembersController(IRepository<BooksAssToMembers> irepository) : base(irepository)
        {
        }

    }
}
