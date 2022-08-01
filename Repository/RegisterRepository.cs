using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.ViewModel;

namespace WebApplication2.Repository
{
    public class RegisterRepository : IRegisterRepository
    {
        private readonly AppDbContext _application;
        private readonly UserManager<IdentityUser> _userManager;
        public RegisterRepository(AppDbContext application, UserManager<IdentityUser> userManager)
        {
            _application = application;
            _userManager = userManager;
        }

        public void Register(RegisterViewModelcs register)
        {
            _application.Add(register);
            Save();
        }
        public  List<UserViewModel> getUsers()
        {
            var Users =   _userManager.Users.Select(u => new UserViewModel()
            {
                Id = u.Id,
                UserName = u.UserName,
                Email = u.Email,
            }).ToList();

            return Users;
        }
        public void Save()
        {
            _application.SaveChanges();
        }
    }
}
