using System;
using System.Collections.Generic;
using CafeManagement.DAO;
using CafeManagement.Entities;

namespace CafeManagement.Services
{
    public class EmployeeService
    {
        private EmployeeDAO employeeDAO;

        public EmployeeService()
        {
            employeeDAO = new EmployeeDAO();
        }

        public bool AddEmployee(Employee employee)
        {
            try
            {
                if (string.IsNullOrEmpty(employee.getId()) ||
                    string.IsNullOrEmpty(employee.getName()) ||
                    string.IsNullOrEmpty(employee.getAddress()) ||
                    string.IsNullOrEmpty(employee.getGender()) ||
                    string.IsNullOrEmpty(employee.getPhoneNumber()))
                {
                    throw new ArgumentException("All employee fields must be provided.");
                }

                if (!IsValidPhoneNumber(employee.getPhoneNumber()))
                {
                    throw new FormatException("Phone number is not in a valid format.");
                }

                Employee existing = employeeDAO.GetEmployee(employee.getId());
                if (existing != null)
                {
                    Console.WriteLine("Employee ID already exists.");
                    return false;
                }

                employeeDAO.AddEmployee(employee);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public bool UpdateEmployee(Employee employee)
        {
            try
            {
                if (string.IsNullOrEmpty(employee.getId()) ||
                    string.IsNullOrEmpty(employee.getName()) ||
                    string.IsNullOrEmpty(employee.getAddress()) ||
                    string.IsNullOrEmpty(employee.getGender()) ||
                    string.IsNullOrEmpty(employee.getPhoneNumber()))
                {
                    throw new ArgumentException("All employee fields must be provided.");
                }

                if (!IsValidPhoneNumber(employee.getPhoneNumber()))
                {
                    throw new FormatException("Phone number is not in a valid format.");
                }

                Employee existing = employeeDAO.GetEmployee(employee.getId());
                if (existing == null)
                {
                    Console.WriteLine("Employee not found.");
                    return false;
                }

                employeeDAO.UpdateEmployee(employee);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public bool DeleteEmployee(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    throw new ArgumentException("Employee ID must be provided.");
                }

                Employee existing = employeeDAO.GetEmployee(id);
                if (existing == null)
                {
                    Console.WriteLine("Employee not found.");
                    return false;
                }

                employeeDAO.DeleteEmployee(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public Employee GetEmployeeById(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    throw new ArgumentException("Employee ID must be provided.");
                }

                return employeeDAO.GetEmployee(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public List<Employee> GetAllEmployees()
        {
            try
            {
                return employeeDAO.GetAllEmployees();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public List<Employee> GetEmployeeByName(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("Employee name must be provided.");
                }

                return employeeDAO.GetEmployeesByName(name);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }
    }
}
