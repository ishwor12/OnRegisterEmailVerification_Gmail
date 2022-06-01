using IdentityManager.Data;
using IdentityManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Repo
{
    public class StudentRepo : Istudent
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddStudent(Student student)
        {
            _dbContext.Student.Add(student);
            _dbContext.SaveChanges();
        }

        public void DeleteStudent(int employeeId)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudent()
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
