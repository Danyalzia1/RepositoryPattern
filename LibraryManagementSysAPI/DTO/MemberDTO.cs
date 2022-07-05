using LibraryManagementSysAPI.Models;
using System.Collections.Generic;

namespace LibraryManagementSysAPI.DbModels
{
    public class MemberDTO
    {
        public int Id { get; set; }
       
        public string MName { get; set; }

        public string MContact { get; set; }
       
        public string MType { get; set; }
       
        public int MNoOfBookIssued { get; set; }


        public ICollection<Book> Books { get; set; }

        public ICollection<Staff> Staffs { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Membership> Memberships { get; set; }
    }
}
