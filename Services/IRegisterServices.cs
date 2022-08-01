using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.ViewModel;

namespace WebApplication2.Services
{
    public interface IRegisterServices
    {
        Task AddRegisterServices(RegisterViewModelcs registerViewModel);
        List<UserViewModel> AllUsers();

        Task<bool> Login(LoginViewModel model);

        Task<bool> LogOut();
        
    }
}
