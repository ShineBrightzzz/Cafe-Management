using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Entities
{
    class Product
    {
        private string id;
        private string name;
        private string typeId;
        private float importPrice;
        private float salePrice;
        private int quantity;
        

        public Product(string id,string name,string typeId,float importPrice,float salePrice,int quantity)
        {
            this.id = id;
            this.name = name;
            this.typeId = typeId;
            this.importPrice = importPrice;
            this.salePrice = salePrice;
            this.quantity = quantity;
            
        }  
        public String getId()
        {
            return id;
        }
        public void setId(String id)
        {
            this.id = id;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getTypeId()
        {
            return typeId;
        }
        public void setTypeId(String typeId)
        {
            this.typeId = typeId;
        }
        public float getImportPrice()
        {
            return importPrice;
        }
        public void setImportPrice(float importPrice)
        {
            this.importPrice = importPrice;
        }
        public float getSalePrice()
        {
            return salePrice;
        }
        public void setSalePrice(float salePrice)
        {
            this.salePrice = salePrice;
        }
        public int getQuantity()
        {
            return quantity;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        
    }
}
