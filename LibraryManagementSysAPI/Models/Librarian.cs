using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel;

namespace LibraryManagementSysAPI.Models
{
    public class Librarian
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50)]
        [DisplayName("Librarian Name")]
        public string Name { get; set; }
        public string ContactNo { get; set; }

        [ForeignKey("LibraryID")]
        public int LibraryID { get; set; }
        public Library Library { get; set; }
       
        public ICollection<Member> Members { get; set; }


    }
}
