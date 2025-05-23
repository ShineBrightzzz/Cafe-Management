using CafeManagement.Entities;
using CafeManagement.Services;
using System;
using System.Collections.Generic;

namespace CafeManagement.Controllers
{
    public class EmployeeController
    {
        private EmployeeService employeeService;

        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }

        public bool AddEmployee(string id, string name, string address, string gender, DateTime dob, string phone)
        {
            var employee = new Employee(id, name, address, gender, dob, phone);

            return employeeService.AddEmployee(employee);
        }

        public bool UpdateEmployee(string id, string name, string address, string gender, DateTime dob, string phone)
        {
            var employee = new Employee(id, name, address, gender, dob, phone);
            return employeeService.UpdateEmployee(employee);
        }

        public bool DeleteEmployee(string id)
        {
            return employeeService.DeleteEmployee(id);
        }

        public Employee GetEmployeeById(string id)
        {
            return employeeService.GetEmployeeById(id);
        }

        public List<Employee> GetEmployeeByName(string name)
        {
            return employeeService.GetEmployeeByName(name);
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeService.GetAllEmployees();
        }
    }
}
