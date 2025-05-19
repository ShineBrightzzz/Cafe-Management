using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Entities
{    public class ProductType
    {
        private string id;
        private string name;

        public ProductType(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Keep the old methods for compatibility
        public string getId()
        {
            return Id;
        }

        public string getName()
        {
            return Name;
        }

        public void setId(string id)
        {
            Id = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }


    }
}
