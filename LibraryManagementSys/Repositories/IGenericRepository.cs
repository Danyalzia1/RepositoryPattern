using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys.Repositories
{
    internal interface IGenericRepository<T>
    {
        List<T> Get();
        bool Insert(T a);
        bool Update(int id, T a);
        bool Delete(int id);

    }
}
