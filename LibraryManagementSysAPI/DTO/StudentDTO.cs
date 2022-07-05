using LibraryManagementSysAPI.Models;

namespace LibraryManagementSysAPI.DbModels
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public int RollNo { get; set; }
        public string Name { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
