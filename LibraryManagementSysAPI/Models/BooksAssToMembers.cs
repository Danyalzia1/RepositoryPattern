using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSysAPI.Models
{
    public class BooksAssToMembers
    {
        [Key]
        public int BomId { get; set; }

        [ForeignKey(" MemberId")]
        public int MemberId { get; set; }
        public Member Member { get; set; }

        [ForeignKey(" BookId")]
        public int BookId { get; set; }
        public Book Book { get; set; }



    }
}
