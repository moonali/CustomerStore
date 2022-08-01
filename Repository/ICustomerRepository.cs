using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public interface ICustomerRepository
    {
        void Add(CustomersDetail customer);
        void Edit(CustomersDetail customer);
        void delete(int Id);
        List<CustomersDetail> GetAll();

        CustomersDetail GetCustomerById(int Id);

    }
}
