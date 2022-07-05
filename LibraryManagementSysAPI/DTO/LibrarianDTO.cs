using LibraryManagementSysAPI.Models;
using System.Collections.Generic;

namespace LibraryManagementSysAPI.DbModels
{
    public class LibrarianDTO
    {

        public int Id { get; set; }
       
        public string Name { get; set; }
        public string ContactNo { get; set; }

        
        public int LibraryID { get; set; }
        public Library Library { get; set; }

        public ICollection<Member> Members { get; set; }

    }
}
