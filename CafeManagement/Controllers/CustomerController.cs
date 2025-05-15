using CafeManagement.Entities;
using CafeManagement.Services;
using System.Collections.Generic;
using CafeManagement.DAO;

namespace CafeManagement.Controllers
{
    public class CustomerController
    {
        private CustomerService customerService;

        public CustomerController()
        {
            customerService = new CustomerService();
        }

        public bool AddCustomer(string id, string name, string phone)
        {
            var customer = new Customer(id, name, phone);
            return customerService.AddCustomer(customer);
        }

        public bool UpdateCustomer(string id, string name, string phone)
        {
            var customer = new Customer(id, name, phone);
            return customerService.UpdateCustomer(customer);
        }

        public bool DeleteCustomer(string id)
        {
            return customerService.DeleteCustomer(id);
        }

        public Customer GetCustomerById(string id)
        {
            return customerService.GetCustomerById(id);
        }

        public List<Customer> GetCustomerByName(string name)
        {
            return customerService.GetCustomerByName(name);
        }

        public List<Customer> GetAllCustomers()
        {
            return customerService.GetAllCustomers();
        }
    }
}
