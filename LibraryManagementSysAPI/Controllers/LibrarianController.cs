using LibraryManagementSysAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrarianController : BaseController<Librarian>
    {
        public LibrarianController(Repositories.IRepository<Librarian> irepository) : base(irepository)
        {
        }
    }
}
