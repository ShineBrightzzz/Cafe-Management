using System;

namespace CafeManagement.Entities
{
    public class Account
    {
        private Guid id;
        private string username;
        private string password;
        private string role;

        public Account(string username, string password, string role)
        {
            this.id = Guid.NewGuid();
            this.username = username;
            this.password = password;
            this.role = role;
        }

        // For loading from DB with existing ID
        public Account(Guid id, string username, string password, string role)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public Guid getId() => id;
        public void setId(Guid id) => this.id = id;

        public string getUsername() => username;
        public void setUsername(string username) => this.username = username;

        public string getPassword() => password;
        public void setPassword(string password) => this.password = password;

        public string getRole() => role;
        public void setRole(string role) => this.role = role;
    }
}
