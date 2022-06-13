using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSys.Models;

namespace LibraryManagementSys.Repositories
{
    public class StudentRepository : BaseRepository<Student>
    {

        

        ICollection<Student> students = new List<Student>()
        {
            new Student{Id=1,Name="Danyal",RollNo=007},
            new Student{Id=2,Name="Areeba",RollNo=008},
            new Student{Id=3,Name="Hayi",RollNo=009},
            new Student {Id=4,Name="Tulaib", RollNo=010},
            new Student {Id=5,Name="Mehmaam",RollNo=011}
        };

        public StudentRepository(LibraryDbContext db) : base(db)
        {
        }
    }
}
