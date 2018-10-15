using System.Collections.Generic;

namespace Championship.Domain.Interfaces
{
   public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj, string uri);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();

    }
}
