using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Get(int Id);
        Task<IEnumerable<TEntity>> GetAll();
        void Add(TEntity entity);
        void Remove (TEntity entity);
        void Update(TEntity entity);
        void Save();
    }
}
