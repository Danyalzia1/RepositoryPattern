using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys.Models
{
    public class Membership
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("id")]
        public int MemberID { get; set; }
        public Member Members { get; set; }
       
        [ForeignKey("id")]
        public int LibraryID { get; set; }
        public Library Libraries { get; set; }
    }
}
