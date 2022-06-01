using IdentityManager.Data;
using IdentityManager.Models;
using IdentityManager.Repo.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Repo
{
    public class DepmtRpo : Idept
    {    
        private readonly ApplicationDbContext _dbContext;
        public DepmtRpo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Department data)
        {
            _dbContext.Department.Add(data);
            _dbContext.SaveChanges();
        }

        public void Delete(Department data)
        {
            _dbContext.Department.Attach(data);
            _dbContext.Entry(data).State = EntityState.Deleted;
            _dbContext.SaveChanges();
        }

        public Department GetById(int Id)
        {
            return _dbContext.Department.FirstOrDefault(x => x.DepartmentId == Id);
        }

        

        public void Update(Department data)
        {
            var entity = GetById(data.DepartmentId);
            _dbContext.Entry(entity).State = EntityState.Detached;
            _dbContext.Department.Attach(data);
            _dbContext.Entry(data).State = EntityState.Modified;

            _dbContext.SaveChanges();
        }

        public List<Department> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
