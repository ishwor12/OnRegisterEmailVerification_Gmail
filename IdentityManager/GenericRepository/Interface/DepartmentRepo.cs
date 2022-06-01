using IdentityManager.Data;
using IdentityManager.GenericRepositorys;
using IdentityManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.GenericRepository.Interface
{
    public class DepartmentRepo : GenericRepository<Department>
    {
        private readonly ApplicationDbContext _dbContext;
        public DepartmentRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }
        public IEnumerable<Department> GetAll()
        {
            var data = _context.Department.ToList();
            return data;
        }
    }
}
