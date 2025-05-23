using System;

namespace CafeManagement.Entities
{
    public class Supplier
    {
        private string id;
        private string name;
        private string phoneNumber;
        private string address;

        public Supplier(string id, string name, string phoneNumber, string address)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public string getId() { return id; }
        public void setId(string value) { id = value; }

        public string getName() { return name; }
        public void setName(string value) { name = value; }

        public string getPhoneNumber() { return phoneNumber; }
        public void setPhoneNumber(string value) { phoneNumber = value; }

        public string getAddress() { return address; }
        public void setAddress(string value) { address = value; }
    }
}
