using IdentityManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Repo.Interface
{
    public interface Idept
    {
        void Add(Department data);
        void Delete(Department data);
        Department GetById(int Id);
        List<Department> GetList();
        void Update(Department data);
    }
}
