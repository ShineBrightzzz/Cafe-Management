using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CafeManagement.DAO;
using CafeManagement.Entities;

namespace CafeManagement.Services
{
    public class CustomerService
    {
        private readonly CustomerDAO customerDAO;

        public CustomerService()
        {
            customerDAO = new CustomerDAO();
        }

        public bool AddCustomer(Customer customer)
        {
            try
            {
                if (string.IsNullOrEmpty(customer.getName()) || string.IsNullOrEmpty(customer.getPhoneNumber()))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên và số điện thoại khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!IsValidPhoneNumber(customer.getPhoneNumber()))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại 10 chữ số, bắt đầu bằng số 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (GetCustomerById(customer.getId()) != null)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return customerDAO.AddCustomer(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                if (string.IsNullOrEmpty(customer.getId()) || string.IsNullOrEmpty(customer.getName()) || 
                    string.IsNullOrEmpty(customer.getPhoneNumber()))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!IsValidPhoneNumber(customer.getPhoneNumber()))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại 10 chữ số, bắt đầu bằng số 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                Customer existing = customerDAO.GetCustomerById(customer.getId());
                if (existing == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return customerDAO.UpdateCustomer(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteCustomer(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                Customer existing = customerDAO.GetCustomerById(id);
                if (existing == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return customerDAO.DeleteCustomer(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Customer GetCustomerById(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    return null;
                }
                return customerDAO.GetCustomerById(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Lỗi lấy danh sách khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Customer>();
            }
        }

        public List<Customer> GetCustomerByName(string name)
        {
            try
            {
                return string.IsNullOrEmpty(name) 
                    ? customerDAO.GetAllCustomers() 
                    : customerDAO.GetCustomerByName(name);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Customer>();
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber)) return false;
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^0\d{9}$");
        }
    }
}
