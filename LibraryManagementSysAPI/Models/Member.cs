using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace LibraryManagementSysAPI.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50)]
        [DisplayName("Member Name")]
        public string MName { get; set; }
        [DisplayName("Member Contact")]

        public string MContact { get; set; }
        [DisplayName("Member Type")]
        public string MType { get; set; }
        [DisplayName("No. of Books Issued")]
        public int MNoOfBookIssued { get; set; }
        

        public ICollection<Book> Books { get; set; }

        public ICollection<Staff> Staffs { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Membership> Memberships { get; set; }

    }
}
