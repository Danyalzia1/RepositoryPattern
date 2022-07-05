
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSysAPI.Data;
using LibraryManagementSysAPI.Models;
namespace LibraryManagementSysAPI.Repositories
{
    public class StaffRepository : BaseRepository<Staff>
    {
/*
        List<Staff> staffs = new List<Staff>() {
        new Staff{StaffId=1,Name="Faraz"},
        new Staff{StaffId=2,Name="Hira"}
        };*/
        public StaffRepository(ApplicationDbContext db) : base(db)
        {
        }
    }

}
