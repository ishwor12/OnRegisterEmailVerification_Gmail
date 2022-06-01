using IdentityManager.Data;
using IdentityManager.Models;
using IdentityManager.Repo.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Repo
{
    public class TeacherRepo : ITeacher
    {
        private readonly ApplicationDbContext _dbContext;

        public TeacherRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Teacher data)
        {
            _dbContext.Teacher.Add(data);
            _dbContext.SaveChanges();
        }

        public void Delete(Teacher data)
        {
            _dbContext.Teacher.Attach(data);
            _dbContext.Entry(data).State = EntityState.Deleted;
            _dbContext.SaveChanges();
        }

       

        public Teacher GetById(int Id)
        {
            return _dbContext.Teacher.FirstOrDefault(x => x.TeacherId == Id);

        }

      
        public void Update(Teacher data)
        {
            throw new NotImplementedException();
        }

        List<Teacher> ITeacher.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
