using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSysAPI.Models
{
    public class Membership
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("MemberID")]
        public int MemberID { get; set; }
        public Member Members { get; set; }

        [ForeignKey("LibraryID")]
        public int LibraryID { get; set; }
        public Library Libraries { get; set; }
    }
}
