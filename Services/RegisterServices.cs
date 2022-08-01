using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Repository;
using WebApplication2.ViewModel;

namespace WebApplication2.Services
{
    public class RegisterServices : IRegisterServices
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IRegisterRepository _registerRepository;

        public RegisterServices( UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IRegisterRepository registerRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _registerRepository = registerRepository;
        }

        public async Task AddRegisterServices(RegisterViewModelcs register)
        {
            var user = new IdentityUser { UserName = register.Emial, Email = register.Emial };

            var result = await _userManager.CreateAsync(user, register.Password);

            if(result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
            }
        }
        public async Task<bool> Login(LoginViewModel model)
        {

            var result = await _signInManager.PasswordSignInAsync(model.Emial,model.Password,false,false);

            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> LogOut()
        {

             await _signInManager.SignOutAsync();
            return true;
        }

        public  List<UserViewModel> AllUsers()
        {
            return _registerRepository.getUsers();
        }
    }
}
