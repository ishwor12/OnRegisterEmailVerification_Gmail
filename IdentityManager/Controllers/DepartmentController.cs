using IdentityManager.Data;
using IdentityManager.GenericRepository.Interface;
using IdentityManager.Interface;
using IdentityManager.Models;
using IdentityManager.Repo.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly IGenericRepository<Department> _department;

        public DepartmentController(IGenericRepository<Department> department)
        {
            
            _department = department;
        }

        public async Task <ActionResult<IEnumerable<Department>>> Index()
        {
           var Department = await _department.GetAll(); // null exception in index view cause.
            return View(Department);// null exception in index view cause.
        }
        public ActionResult Details(int id)
        {
            return View(new Department());
        }

        //GET: CustomerController/Create
        public ActionResult Create()
        {
           
                return View();
           
        }

        // POST: CustomerController/Create
        [HttpPost]

        public ActionResult Create(Department Department)
        {
            if (ModelState.IsValid)
            {
                _department.Add(Department);

            }

            return RedirectToAction("Index");
        }



    }
}



