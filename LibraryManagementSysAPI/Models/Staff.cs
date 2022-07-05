using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSysAPI.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50)]
        [DisplayName("Staff Name")]
        public string Name { get; set; }

        [ForeignKey("MemberID")]
        public int MemberID { get; set; }
        public Member Member { get; set; }
       
    }
}
