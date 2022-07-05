using LibraryManagementSysAPI.DbModels;
using LibraryManagementSysAPI.Models;
using AutoMapper;
namespace LibraryManagementSysAPI.Profiles
{
    public class MemberDTOProfile : Profile
    {
        public MemberDTOProfile()
        {
            CreateMap<Member,MemberDTO>();
        }
    }
}
