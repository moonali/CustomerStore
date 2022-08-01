using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _application;

        public CustomerRepository(AppDbContext application)
        {
            _application = application;
        }

        public void Add(CustomersDetail customer)
        {
             _application.Add(customer);
            Save();
        }

        public void delete(int Id)
        {
            _application.Remove(_application.CustomersDetail.Find(Id));
            Save();
                                  
        }

        public void Edit(CustomersDetail model)
        {

            _application.Entry(model).State = EntityState.Modified;
            Save();
        }

        public List<CustomersDetail> GetAll()
        {
            var result = (from c in _application.CustomersDetail
                         select c).ToList();

            var customer = new List<CustomersDetail>();
            customer = result;

            return customer;
        }

        public CustomersDetail GetCustomerById(int Id)
        {
            var result = new CustomersDetail();
            result = _application.CustomersDetail.Find(Id);
            return result;
        }

        public void Save()
        {
            _application.SaveChanges();
        }
    }
}
