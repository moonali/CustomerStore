using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.ViewModel;

namespace WebApplication2.Repository
{
    public interface IRegisterRepository
    {
        void Register(RegisterViewModelcs register);
        List<UserViewModel> getUsers();

       
    }
}
