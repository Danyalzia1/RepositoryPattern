using AutoMapper;
using LibraryManagementSysAPI.DbModels;
using LibraryManagementSysAPI.Models;
namespace LibraryManagementSysAPI.Profiles
{
    public class StaffDTOProfile :Profile
    {
        public StaffDTOProfile()
        {
            CreateMap<Staff,StaffDTO>();
        }
    }
}
