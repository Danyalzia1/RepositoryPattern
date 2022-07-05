using LibraryManagementSysAPI.Models;

namespace LibraryManagementSysAPI.DbModels
{
    public class StaffDTO
    {
        public int StaffId { get; set; }

        
        public string Name { get; set; }

        public int MemberID { get; set; }
        public Member Member { get; set; }
    }
}
