using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryManagementSys.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected LibraryDbContext db;
        public BaseRepository(LibraryDbContext db)
        {
            this.db = db;
        }
        public bool Add(T entity)
        {
           
             db.Set<T>().Add(entity);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var itemToDelete = this.Get(id);
            db.Set<T>().Remove(itemToDelete);
            db.SaveChanges();
            return true;
        }

        public T Get(int id)
        {
            return db.Set<T>().Find(id);
        }

        public ICollection<T> GetAll()
        {
            var data = db.Set<T>().ToList();
            return data;
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public bool Update(T entity)
        {
            return true;
        }

    }
}
