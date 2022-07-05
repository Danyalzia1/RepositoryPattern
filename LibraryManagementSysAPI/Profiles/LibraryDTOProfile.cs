using AutoMapper;
using LibraryManagementSysAPI.DbModels;
using LibraryManagementSysAPI.Models;
namespace LibraryManagementSysAPI.Profiles
{
    public class LibraryDTOProfile : Profile
    {
        public LibraryDTOProfile()
        {
            CreateMap<Library, LibraryDTO>();
        }
    }
}
