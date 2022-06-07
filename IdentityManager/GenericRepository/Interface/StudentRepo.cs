using IdentityManager.Data;
using IdentityManager.GenericRepositorys;
using IdentityManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.GenericRepository.Interface
{
    public class StudentRepo : GenericRepository<Student>, IStudentRepo
    {
        private readonly ApplicationDbContext _dbContext;
        public StudentRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }
      

        public IEnumerable<Customer> GetStudent(int count)
        {
            throw new NotImplementedException();
        }
    }
}
