using LibraryManagementSysAPI.Repositories;
using System.Collections.Generic;

namespace LibraryManagementSysAPI.Services
{
    public class BaseService<T> : IService<T>
    {
        protected IRepository<T> Repo;
        public BaseService(IRepository<T> Repo)
        {
            this.Repo = Repo;
        }

        public bool Add(T obj)
        {
            return Repo.Add(obj);


        }

        public bool Delete(int id)
        {
            return Repo.Delete(id);
        }

        public ICollection<T> Get()
        {
            return Repo.GetAll();

        }

        public T Get(int id)
        {
            return Repo.Get(id);
        }

        public bool Update(T obj)
        {
            return Repo.Update(obj);
        }
    }
}
