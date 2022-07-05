using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;

namespace LibraryManagementSysAPI.Models
{
    public class Library
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50)]
        [DisplayName("Library Name")]
        public string Name { get; set; }

        public ICollection<Librarian> Librarians { get; set; }

        public ICollection<Book> Books { get; set; }
        public ICollection<Membership> Memberships { get; set; }

    }
}
