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
        private string phone;

        public Customer(string id, string name, string phone)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
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
            return phone;
        }

        public void setPhoneNumber(string value)
        {
            phone = value;
        }
    }
}
