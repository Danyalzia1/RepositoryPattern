using AutoMapper;
using LibraryManagementSysAPI.DbModels;
using LibraryManagementSysAPI.Models;


namespace LibraryManagementSysAPI.Profiles
{
    public class BookAssToMembersDTOProfile : Profile
    {
        public BookAssToMembersDTOProfile()
        {
            CreateMap<BooksAssToMembers, BooksAssToMembersDTO>();
        }
    }
}
