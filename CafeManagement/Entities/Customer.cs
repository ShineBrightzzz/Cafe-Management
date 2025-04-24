using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Entities
{
    public class Customer
    {
        private string id;
        private string name;
        private string phoneNumber;

        public Customer(string id, string name, string phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public string getId()
        {
            return id;
        }

        public void setId(string value)
        {
            id = value;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string value)
        {
            name = value;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setPhoneNumber(string value)
        {
            phoneNumber = value;
        }
    }
}
