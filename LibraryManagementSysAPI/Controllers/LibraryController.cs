using AutoMapper;
using LibraryManagementSysAPI.ExceptionLogs;
using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : BaseController<Library>
    {
        public LibraryController(IService<Library> repo, ILogger logger, IMapper mapper) : base(repo, logger, mapper)
        {
        }
    }
}
