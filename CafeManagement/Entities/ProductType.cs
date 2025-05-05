using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Entities
{
    public class ProductType
    {
        private string id;
        private string name;

        public ProductType(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public string getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }


    }
}
