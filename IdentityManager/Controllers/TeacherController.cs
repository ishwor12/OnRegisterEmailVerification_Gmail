using IdentityManager.Data;
using IdentityManager.GenericRepository.Interface;
using IdentityManager.Interface;
using IdentityManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Controllers
{
    public class TeacherController : Controller
    {

        private readonly IGenericRepository<Teacher> _repository;
        public TeacherController(IGenericRepository<Teacher> repository, IStudentRepo studentRepo)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Teacher> teachers = await _repository.GetAll();
            
            return View(teachers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View(new Teacher());
        }

        // GET: CustomerController/Create
        public  ActionResult Create() 
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]

        public ActionResult Create(Teacher Teachers)
        {
            if (ModelState.IsValid)
            {

                _repository.Add(Teachers);


            }
           
            return RedirectToAction("Index");
        }

        
        // GET: CustomerController/Edit/5


        public ActionResult Edit(int Id)
        {
            Teacher model = _repository.Get(Id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Teacher model)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(model);
                _repository.Save();
                return RedirectToAction("Index", "Teacher");
            }
            else
            {
                return View(model);
            }
        }
            // GET: CustomerController/Delete/5
            public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
      
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
