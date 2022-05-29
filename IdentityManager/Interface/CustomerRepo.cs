using IdentityManager.Data;
using IdentityManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Interface
{
    public class CustomerRepo : ICustomer
    {
            private readonly ApplicationDbContext _dbContext;

        public CustomerRepo()
        {
        }

        public CustomerRepo(ApplicationDbContext dbContext)
            {
            _dbContext =  dbContext;
            }
            public void Add(Customer data)
        {
            _dbContext.Customer.Add(data);
            _dbContext.SaveChanges();
        }

        public void Delete(Customer data)
        {
            _dbContext.Customer.Attach(data);
            _dbContext.Entry(data).State = EntityState.Deleted;
            _dbContext.SaveChanges();
        }

        public Customer GetById(int Id)
        {
            return _dbContext.Customer.FirstOrDefault(x => x.Id == Id);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetList()
        {
            return _dbContext.Customer.ToList();
        }

        public void Update(Customer data)
        {
            throw new NotImplementedException();
        }
    }
}
