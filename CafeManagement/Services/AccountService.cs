using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.DAO;
using CafeManagement.Entities;
using DocumentFormat.OpenXml.Presentation;
using System.Security.Cryptography;
using BCrypt.Net;

namespace CafeManagement.Services
{
    public class AccountService
    {
        private readonly AccountDAO accountDao;

        public AccountService()
        {
             accountDao = new AccountDAO();
        }

        //Truyền password để mã hóa
        public Account GetAccountByUsername(string username)
        {
            return accountDao.GetAccountByUserName(username);
        }
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password); 
        }

        public bool Login(string username, string password)
        {
            var account = accountDao.GetAccountByUserName(username);
            if (account == null) return false;

            return BCrypt.Net.BCrypt.Verify(password, account.getPassword()); 
        }

        public bool Register(Account account, string rawPassword)
        {
            if (accountDao.IsEmployeeIdRegistered(account.getEmployeeId()))
            {
                MessageBox.Show("Nhân viên này đã có tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!accountDao.IsEmployeeIdExist(account.getEmployeeId()))
            {
                MessageBox.Show("Mã nhân viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            account.setPassword(HashPassword(rawPassword));
            return accountDao.CreateAccount(account);
        }
    }
}
