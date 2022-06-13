using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys.Models
{
    public class Librarian
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }

        [ForeignKey("id")]
        public int LibraryID { get; set; }
        public Library Library { get; set; }
        public ICollection<Book> Books { get; set; }

        public ICollection<Member> Members { get; set; }


        /*public void AddLibrarian() { }
        public int RemoveLibrarian(int id) { return 0; }
        public int UpdateInfo(int id) { return 0; }
        public int Login(string username, string password) { return 0; }*/

    }
}
