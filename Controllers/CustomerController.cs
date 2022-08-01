using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        protected readonly ICustomerServices _customerServices;

        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        public IActionResult Index()
        {
            
            return View(_customerServices.GetAllCustomerServices());
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult AddCustomer(CustomersDetail model)
        {
            if (!ModelState.IsValid) return null;
           _customerServices.AddServices(model);
            return RedirectToAction("Index","Customer");
        }
        [HttpGet]
        public IActionResult EditCustomer(int Id)
        {
            return View(_customerServices.GetCustomerById(Id));
        }
        [HttpPost]
        public IActionResult EditCustomer(CustomersDetail model)
        {
            _customerServices.EditServices(model);
            return RedirectToAction("Index", "Customer");
        }

        [HttpGet]
        public IActionResult DeleteCustomer(int Id)
        {
            _customerServices.deleteServices(Id);
            return RedirectToAction("Index", "Customer");
        }
        public IActionResult CustomerDetail(int Id)
        {
            return View(_customerServices.GetCustomerById(Id));
        }
        [HttpGet]
        public JsonResult CustomerStatus(int Id)
        {
            return Json(_customerServices.GetCustomerById(Id));
        }


    }
}
