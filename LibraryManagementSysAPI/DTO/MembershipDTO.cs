using LibraryManagementSysAPI.Models;

namespace LibraryManagementSysAPI.DbModels
{
    public class MembershipDTO
    {

        public int Id { get; set; }

        public int MemberID { get; set; }
        public Member Members { get; set; }

        public int LibraryID { get; set; }
        public Library Libraries { get; set; }
    }
}
