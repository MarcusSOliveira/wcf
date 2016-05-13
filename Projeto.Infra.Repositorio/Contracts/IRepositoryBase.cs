using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infra.Repositorio.Contracts
{
    public interface IRepositoryBase<TEntity, TKey >
        where TEntity : class
        where TKey : struct
    {
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);

        List<TEntity> FindAll();
        TEntity FindById(TKey key);

    }
}
