using LibraryManagementSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSys.Repositories;

namespace LibraryManagementSys
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\t\tRegistered Libraries");
            BaseRepository<Library> libararies=new LibrarianRepository();
            foreach (Library library in libararies.GetAll())
            {
                Console.WriteLine("Library ID: "+library.Id+"Name: "+library.Name+"Members: ");
            }

            Console.ReadKey();


        }
    }
}
