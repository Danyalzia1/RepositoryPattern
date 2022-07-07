﻿using AutoMapper;
using LibraryManagementSysAPI.ExceptionLogs;
using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrarianController : BaseController<Librarian>
    {
        public LibrarianController(IService<Librarian> repo, ILogger logger, IMapper mapper) : base(repo, logger, mapper)
        {
        }
    }
}
