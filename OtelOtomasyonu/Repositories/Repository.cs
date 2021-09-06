using OtelOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.Repositories
{
   public class Repository<T> where T:class,new()
    {
        DbOtelEntities db = new DbOtelEntities();

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }
        public void Add(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
        public void Delete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }
        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }
        public void Update()
        {
            db.SaveChanges();
        }
    }
}
