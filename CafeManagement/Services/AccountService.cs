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
using System.Windows.Forms;

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
            return accountDao.GetAccountByUsername(username);
        }
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password); 
        }

        public bool Login(string username, string password)
        {
            var account = accountDao.GetAccountByUsername(username);
            if (account == null) return false;

            return BCrypt.Net.BCrypt.Verify(password, account.getPassword()); 
        }

        public bool Register(string username, string rawPassword, string role)
        {
            var hashedPassword = HashPassword(rawPassword);
            var account = new Account(username, hashedPassword, role);
            return accountDao.AddAccount(account);
        }
    }
}
