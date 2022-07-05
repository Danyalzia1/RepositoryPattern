using AutoMapper;
using LibraryManagementSysAPI.DbModels;
using LibraryManagementSysAPI.Models;
namespace LibraryManagementSysAPI.Profiles
{
    public class LibrarianDTOProfile : Profile
    {
        public LibrarianDTOProfile()
        {
            CreateMap<Librarian,LibrarianDTO>();
        }
    }
}
