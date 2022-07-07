using AutoMapper;
using LibraryManagementSysAPI.ExceptionLogs;
using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Repositories;
using LibraryManagementSysAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipController : BaseController<Membership>
    {
        public MembershipController(IService<Membership> repo, ILogger logger, IMapper mapper) : base(repo, logger, mapper)
        {
        }
    }
}
