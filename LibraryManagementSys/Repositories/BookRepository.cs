using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSys.Models;

namespace LibraryManagementSys.Repositories
{
    public class BookRepository : BaseRepository<Book>
    {

        List<Book> booklist = new List<Book>()
        {
            new Book{BookId=1,BookName="Gone Girl",Author="Gillian Flynn", LibraryId=1,Price=560,LibrarianId=1,MemberId=3},
            new Book{BookId=2, BookName="True Detective", Author="Nathan Heller", LibraryId=1,Price=650,LibrarianId=1,MemberId=4},
            new Book{BookId=3, BookName = "Around The World in 80 Days",Author="Jules Verne and Peter Holeinone", LibraryId=1,Price=270,LibrarianId=1,MemberId=3}
        };
        public BookRepository(LibraryDbContext db) : base(db)
        {
        }
    }
}
