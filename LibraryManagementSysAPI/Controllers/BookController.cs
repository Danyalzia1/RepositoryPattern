using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Repositories;

namespace LibraryManagementSysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : BaseController<Book>
    {
        public BookController(IRepository<Book> irepository) : base(irepository)
        {
        }
    }
}
