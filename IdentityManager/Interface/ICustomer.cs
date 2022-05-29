using IdentityManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Interface
{
    interface ICustomer
    {
        void Add(Customer data);
        IEnumerable<Customer> GetCustomers();
        void Delete(Customer data);
        Customer GetById(int Id);
        List<Customer> GetList();
        void Update(Customer data);
    }
}
