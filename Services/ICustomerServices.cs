using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
   public interface ICustomerServices
    {
        void AddServices(CustomersDetail customer);
        void EditServices(CustomersDetail customer);
        CustomersDetail GetCustomerById(int  Id);
        void deleteServices(int Id);

        List<CustomersDetail> GetAllCustomerServices();
    }
}
