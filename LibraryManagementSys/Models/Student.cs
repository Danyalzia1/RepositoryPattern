using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public int RollNo { get; set; }
        public string Name { get; set; }
        
        [ForeignKey("id")]
        public int MemberId { get; set; }
        public Member Member { get; set; }

    }
}
