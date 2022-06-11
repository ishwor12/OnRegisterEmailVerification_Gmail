using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IdentityManager.Models;
using Microsoft.AspNetCore.Authorization;

namespace IdentityManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public JsonResult CreateStudent(int StudentId,string name,string ContactNumber, string EmailAddress, string Address, string Batch, DateTime AddmissionDate, int RegistrationNo)
        {
            Student std = new Student
            {
                Name = name,
                ContactNumber= ContactNumber,
                EmailAddress = EmailAddress,
              Address = Address,
                Batch         = Batch,
                AddmissionDate =AddmissionDate,
                RegistrationNo=RegistrationNo
            };
            return Json(std);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
