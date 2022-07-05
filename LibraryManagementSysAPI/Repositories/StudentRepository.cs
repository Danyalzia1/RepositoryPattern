using System.Collections.Generic;
using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Data;


namespace LibraryManagementSysAPI.Repositories
{
    public class StudentRepository : BaseRepository<Student>
    {



      /*  List<Student> students = new List<Student>()
        {
            new Student{Id=1,Name="Danyal",RollNo=007},
            new Student{Id=2,Name="Areeba",RollNo=008},
            new Student{Id=3,Name="Hayi",RollNo=009},
            new Student {Id=4,Name="Tulaib", RollNo=010},
            new Student {Id=5,Name="Mehmaam",RollNo=011}
        };*/

        public StudentRepository(ApplicationDbContext db) : base(db)
        {
        }
    }

}
