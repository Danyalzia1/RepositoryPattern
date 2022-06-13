﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys.Models
{
    public class Library
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Librarian> Librarians { get; set; }
        
        public ICollection<Book> Books { get; set; }
        public ICollection<Membership> Memberships { get; set; }
    }
}
