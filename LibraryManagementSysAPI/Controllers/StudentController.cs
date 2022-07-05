using LibraryManagementSysAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : BaseController<Student>
    {
        public StudentController(Repositories.IRepository<Student> irepository) : base(irepository)
        {
        }
    }
}
