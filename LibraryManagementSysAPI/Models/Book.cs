using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSysAPI.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [DisplayName("Book Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "An Album Title is required")]
        public string BookName { get; set; }
        [Range(1, 5000.00,
            ErrorMessage = "Price must be between 1 and 5000.")]
        public int Price { get; set; }
        public string Author { get; set; }

        public DateTime DateIssue { get; set; }
        public DateTime DateReturn { get; set; }


        [ForeignKey("LibraryId")]
        public int LibraryId { get; set; }
        public Library Library { get; set; }
     

        public ICollection<Member> Members { get; set; }





    }
}
