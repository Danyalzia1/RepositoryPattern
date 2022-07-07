using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Repositories;
using LibraryManagementSysAPI.Services;
using LibraryManagementSysAPI.ExceptionLogs;
using AutoMapper;

namespace LibraryManagementSysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : BaseController<Book>
    {
        public BookController(IService<Book> repo, ILogger logger, IMapper mapper) : base(repo, logger, mapper)
        {
        }
    }
}
