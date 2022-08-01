using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Services
{
    public class CustomerServices : ICustomerServices
    {
        public readonly ICustomerRepository _customerRepository;

        public CustomerServices(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddServices(CustomersDetail customer)
        {
            _customerRepository.Add(customer);
        }

        public void deleteServices(int Id)
        {
            _customerRepository.delete(Id);
        }

        public void EditServices(CustomersDetail model)
        {
             _customerRepository.Edit(model);
        }

        public List<CustomersDetail> GetAllCustomerServices()
        {
            return _customerRepository.GetAll();
        }

        public CustomersDetail GetCustomerById(int Id)
        {
            return _customerRepository.GetCustomerById(Id);
        }
    }
}
