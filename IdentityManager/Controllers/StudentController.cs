using IdentityManager.Data;
using IdentityManager.Interface;
using IdentityManager.Models;
using IdentityManager.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _DbContext;
        public StudentController(ApplicationDbContext context)
        {
            _DbContext = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Student>>> Index()
        {
            var students = _DbContext.Student.ToList();
            return View(students);
        }
        public ActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult Create(Student Student)
        {
            if (ModelState.IsValid)
            {
                _DbContext.Add(Student);
                return RedirectToAction("Create");
            }
            return View();
        }
    }
}
