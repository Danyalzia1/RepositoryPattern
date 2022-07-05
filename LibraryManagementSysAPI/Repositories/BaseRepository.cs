using System.Collections.Generic;
using System.Linq;
using LibraryManagementSysAPI.Data;

namespace LibraryManagementSysAPI.Repositories { 
  public abstract class BaseRepository<T> : IRepository<T> where T : class
        {
            protected ApplicationDbContext db;
            public BaseRepository(ApplicationDbContext db)
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
            return default(T);
        }

        public bool Update(T entity)
        {
            db.Set<T>().Update(entity);
            return true;
        }


    }

    }
