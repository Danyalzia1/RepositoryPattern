using System;
using System.Collections.Generic;
using LibraryManagementSysAPI.Models;

namespace LibraryManagementSysAPI.DbModels
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }

        public DateTime DateIssue { get; set; }
        public DateTime DateReturn { get; set; }
        public int LibraryId { get; set; }
        public Library Library { get; set; }
        public ICollection<Member> Members { get; set; }


    }
}
