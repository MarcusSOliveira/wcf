using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Infra.Repositorio.DataSource;
using Projeto.Infra.Repositorio.Contracts;
using System.Data.Entity;

namespace Projeto.Infra.Repositorio.Persistence
{
    public abstract class RepositorioBase<TEntity, TKey>
        : IRepositoryBase<TEntity, TKey>
        where TEntity : class
        where TKey : struct
    {

        public void Insert(TEntity obj)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(obj).State = EntityState.Added;
                d.SaveChanges();
            }
        }

        public void Update(TEntity obj)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(obj).State = EntityState.Modified;
                d.SaveChanges();
            }
        }
        public void Delete(TEntity obj)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(obj).State = EntityState.Deleted;
                d.SaveChanges();
            }
        }

        public List<TEntity> FindAll()
        {
            using (DataContext d = new DataContext())
            {
                return d.Set<TEntity>().ToList();
                
            }
        }

        public TEntity FindById(TKey key)
        {
            using (DataContext d = new DataContext())
            {
                return d.Set<TEntity>().Find(key);

            }
        }

       
    }
}
