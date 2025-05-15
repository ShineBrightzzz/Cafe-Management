using System;
using System.Collections.Generic;
using CafeManagement.DAO;
using CafeManagement.Entities;

namespace CafeManagement.Services
{
    public class CustomerService
    {
        private CustomerDAO customerDAO;

        public CustomerService()
        {
            customerDAO = new CustomerDAO();
        }

        public bool AddCustomer(Customer customer)
        {
            try
            {
                if (string.IsNullOrEmpty(customer.getId()) || string.IsNullOrEmpty(customer.getName()) || string.IsNullOrEmpty(customer.getPhoneNumber()))
                {
                    throw new ArgumentException("All customer fields (ID, Name, Phone) must be provided.");
                }

                // Kiểm tra dữ liệu hợp lệ, ví dụ: định dạng số điện thoại
                if (!IsValidPhoneNumber(customer.getPhoneNumber()))
                {
                    throw new FormatException("Phone number is not in a valid format.");
                }

                Customer existing = customerDAO.GetCustomerById(customer.getId());
                if (existing != null)
                {
                    Console.WriteLine("Customer ID already exists.");
                    return false;
                }

                customerDAO.AddCustomer(customer);
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                if (string.IsNullOrEmpty(customer.getId()) || string.IsNullOrEmpty(customer.getName()) || string.IsNullOrEmpty(customer.getPhoneNumber()))
                {
                    throw new ArgumentException("All customer fields (ID, Name, Phone) must be provided.");
                }

                if (!IsValidPhoneNumber(customer.getPhoneNumber()))
                {
                    throw new FormatException("Phone number is not in a valid format.");
                }

                Customer existing = customerDAO.GetCustomerById(customer.getId());
                if (existing == null)
                {
                    Console.WriteLine("Customer not found.");
                    return false;
                }

                customerDAO.UpdateCustomer(customer);
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }

        public bool DeleteCustomer(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    throw new ArgumentException("Customer ID must be provided.");
                }

                Customer existing = customerDAO.GetCustomerById(id);
                if (existing == null)
                {
                    Console.WriteLine("Customer not found.");
                    return false;
                }

                customerDAO.DeleteCustomer(id);
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }

        public Customer GetCustomerById(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    throw new ArgumentException("Customer ID must be provided.");
                }

                return customerDAO.GetCustomerById(id);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return null;
            }
        }

        public List<Customer> GetAllCustomers()
        {
            try
            {
                return customerDAO.GetAllCustomers();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public List<Customer> GetCustomerByName(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("Customer name must be provided.");
                }

                return customerDAO.GetCustomerByName(name);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return null;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Cấu trúc kiểm tra định dạng số điện thoại (ví dụ đơn giản)
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }
    }
}
