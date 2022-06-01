using IdentityManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Repo.Interface
{
   public  interface ITeacher
    {
        void Add(Teacher data);
        void Delete(Teacher data);
        Teacher GetById(int Id);
        List<Teacher> GetAll();
        void Update(Teacher data);
    }
}
