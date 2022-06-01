using IdentityManager.Interface;
using IdentityManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.GenericRepository.Interface
{
    interface ITeacher : IGenericRepository<Teacher>
    {
        IEnumerable<Teacher> GetBestTeacher(int count);
    }
}
