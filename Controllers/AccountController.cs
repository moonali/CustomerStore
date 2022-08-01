using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Services;
using WebApplication2.ViewModel;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        protected readonly IRegisterServices _registerServices;


        public AccountController(IRegisterServices registerServices)
        {
              _registerServices = registerServices;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModelcs model)
        {
            if(!ModelState.IsValid) return null;

            await _registerServices.AddRegisterServices(model);

             return RedirectToAction("AllUser", "Account");
        }
        [HttpGet]
        public async Task<IActionResult> AllUser()
        {
            var result = _registerServices.AllUsers();
            return View(result);
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return null;

            if(await _registerServices.Login(model))
            {
                return RedirectToAction("Index", "Customer");
            }

             ModelState.AddModelError(string.Empty,"Please provide correct user name or password");

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _registerServices.LogOut();
            return RedirectToAction("login", "Account");
        }
    }
}
