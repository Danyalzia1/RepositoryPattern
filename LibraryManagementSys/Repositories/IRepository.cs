﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys.Repositories
{
    public interface IRepository<T>
    {
        ICollection<T> GetAll();

        T Get(int id);

        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
        T GetById(int id);
    }
}
