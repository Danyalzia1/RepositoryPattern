using AutoMapper;
using LibraryManagementSysAPI.DbModels;
using LibraryManagementSysAPI.Models;

namespace LibraryManagementSysAPI.Profiles
{
    public class BookDTOProfile : Profile
    {
        public BookDTOProfile()
        {
            CreateMap<Book,BookDTO>();
        }
    }
}
