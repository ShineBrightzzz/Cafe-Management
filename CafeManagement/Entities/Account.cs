using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Entities
{
    public class Account
    {
        private String Id;
        private String employeeId;
        private String username;
        private String password;
        private String role;

        public Account(string id, string employeeId, string username, string password, string role)
        {
            this.Id = id;
            this.employeeId = employeeId;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public string getId()
        {
            return Id;
        }

        public string getEmployeeId()
        {
            return employeeId;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

        public string getRole()
        {
            return role;
        }

        public void setId(string id)
        {
            Id = id;
        }

        public void setEmployeeId(string employeeId)
        {
            this.employeeId = employeeId;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setRole(string role)
        {
            this.role = role;
        }
    }
}
