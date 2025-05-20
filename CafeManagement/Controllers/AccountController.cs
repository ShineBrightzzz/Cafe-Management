using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Entities;
using CafeManagement.Services;

namespace CafeManagement.Controllers
{
    public class AccountController
    {
        private readonly AccountService accountService = new AccountService();

        public Account GetAccount(string username)
        {
            return accountService.GetAccountByUsername(username);
        }

        public bool Login(string username, string password)
        {
            return accountService.Login(username, password);
        }

        public bool Register(string username, string password, string role)
        {
            return accountService.Register(username, password, role);
        }
    }
}
