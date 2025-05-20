using CafeManagement.Services;
using System;

namespace CafeManagement.Utils
{
    public class AccountGenerator
    {
        public static void GenerateSampleAccounts()
        {
            var accountService = new AccountService();

            accountService.Register("employee", "123456", "Employee");

            Console.WriteLine("Đã tạo xong tài khoản mẫu:");
        }
    }
}