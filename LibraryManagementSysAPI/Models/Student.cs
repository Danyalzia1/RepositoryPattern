using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSysAPI.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Roll No. is required.")]
        [StringLength(160)]
        [DisplayName("Roll Number")]
        public int RollNo { get; set; }
        public string Name { get; set; }

        [ForeignKey("MemberId")]
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}

