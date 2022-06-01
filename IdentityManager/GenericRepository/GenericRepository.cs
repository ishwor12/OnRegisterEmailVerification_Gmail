using IdentityManager.Data;
using IdentityManager.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.GenericRepositorys
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext _context ;
        public GenericRepository(ApplicationDbContext context)
        {
         _context = context;
        }



        public  virtual async Task<IEnumerable<TEntity>>GetAll()
        {
            var data=  await _context.Set<TEntity>().ToListAsync();
            return data;
        }

        public  TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }



        public  void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
