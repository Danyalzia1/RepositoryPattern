using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public string MName { get; set; }
        public string MContact { get; set; }
        public string MType { get; set; }
        public int MNoOfBookIssued { get; set; }

        public ICollection<Book> Books { get; set; } 

        public ICollection<Staff> Staffs { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Membership> Memberships { get; set; }

        /*public void AddMember()
        {

        }

        public int UpdateMember() { return 0; }
        public void IssueBook(int Bookid) { }

        public void ReturnBook(int Bookid) { }

        public void Registration() { }

        public int Authentication(int mID) { return 0; }*/
    }
}
