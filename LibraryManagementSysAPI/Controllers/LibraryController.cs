using LibraryManagementSysAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : BaseController<Library>
    {
        public LibraryController(Repositories.IRepository<Library> irepository) : base(irepository)
        {
        }
    }
}
