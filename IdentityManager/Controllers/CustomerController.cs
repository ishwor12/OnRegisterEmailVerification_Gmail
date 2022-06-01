using IdentityManager.Interface;
using IdentityManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IdentityManager.Controllers
{
    public class CustomerController : Controller
    {
        private IGenericRepository<Customer> _repository;
        public CustomerController(IGenericRepository<Customer> repository)
        {
            _repository = repository;
        }

        // GET: CustomerController
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Customer>>> Index()
        {
            var Customer = await _repository.GetAll();
            return View(Customer);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer Customer)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(Customer);

            }
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int Id)
        {
            Customer model = _repository.Get(Id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Customer model)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(model);
                _repository.Save();
                return RedirectToAction("Index", "Customer");
            }
            else
            {
                return View(model);
            }


        }
    }
}



