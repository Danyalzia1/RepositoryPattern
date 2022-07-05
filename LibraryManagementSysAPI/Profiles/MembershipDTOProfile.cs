using AutoMapper;
using LibraryManagementSysAPI.DbModels;
using LibraryManagementSysAPI.Models;
namespace LibraryManagementSysAPI.Profiles
{
    public class MembershipDTOProfile : Profile
    {
        public MembershipDTOProfile()
        {
            CreateMap<Membership,MembershipDTO>();
        }
    }
}
