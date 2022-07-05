using AutoMapper;
using LibraryManagementSysAPI.DbModels;
using LibraryManagementSysAPI.Models;
namespace LibraryManagementSysAPI.Profiles
{
    public class StudentDTOProfile : Profile
    {
        public StudentDTOProfile()
        {
            CreateMap<Student, StudentDTO>();
        }
    }
}
