using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys.Models
{
    public class Book 
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }

        [ForeignKey("id")]
        public int LibraryId { get; set; }
        public Library Library { get; set; }
        
        [ForeignKey("id")]
        public int LibrarianId { get; set; }
        public Librarian Librarian { get; set; }
        
        [ForeignKey("id")]
        public int MemberId { get; set; }
        public Member Member { get; set; }

        [ForeignKey("id")]
        public int StaffId { get; set; }

        public Staff Staff { get; set; }
        /*public void addBook()
        {

        }
        public int UpdateBook() { return 0; }

        public int RemoveBook(int bookid) { return 0; }

        public void IssueBook(int bookid) {  }

        public void ReturnBook(int bookid) { }*/

        
    }
}
