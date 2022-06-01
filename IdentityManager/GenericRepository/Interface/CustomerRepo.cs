using IdentityManager.Data;

using IdentityManager.GenericRepositorys;
using IdentityManager.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Interface
{
    public class CustomerRepo : GenericRepository<Customer>, ICustomer
    {
            private readonly ApplicationDbContext _dbContext;

        public CustomerRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }

        
        public IEnumerable<Customer> GetTopSellingCustomer(int count)
        {
            throw new System.NotImplementedException();
        }
        public  IEnumerable<Customer> GetAll()
        {
            var data =  _context.Customer.ToList();
            return data;
        }
      

    }
}
