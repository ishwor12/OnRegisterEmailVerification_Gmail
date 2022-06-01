using IdentityManager.GenericRepositorys;
using IdentityManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Interface
{
    public interface ICustomer:IGenericRepository<Customer>
    {
        IEnumerable<Customer> GetTopSellingCustomer(int count);
    }
}
