using LibraryManagementSysAPI.Models;

namespace LibraryManagementSysAPI.DbModels
{
    public class BooksAssToMembersDTO
    {
        public int BomId { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
