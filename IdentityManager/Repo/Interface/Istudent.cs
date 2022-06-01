using IdentityManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Repo
{
   public  interface Istudent
    {
      
         List<Student> GetStudent();
        void AddStudent(Student student);
       void  UpdateStudent(Student student);
        void DeleteStudent(int employeeId);
    }
}
