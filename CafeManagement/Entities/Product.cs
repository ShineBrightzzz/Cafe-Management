using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Entities
{
    public class Product
    {
        private string id;
        private string name;
        private string typeId;
        private double importPrice;
        private double salePrice;
        private int quantity;
        private string image;
        

        public Product(string id,string name,string typeId,double importPrice,double salePrice,int quantity, string image)
        {
            this.id = id;
            this.name = name;
            this.typeId = typeId;
            this.importPrice = importPrice;
            this.salePrice = salePrice;
            this.quantity = quantity;
            this.image = image;
            
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
        public double getImportPrice()
        {
            return importPrice;
        }
        public void setImportPrice(double importPrice)
        {
            this.importPrice = importPrice;
        }
        public double getSalePrice()
        {
            return salePrice;
        }
        public void setSalePrice(double salePrice)
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
        public string getImage()
        {
            return image;
        }
        public void setImage(String image)
        {
            this.image = image;
        }
        
    }
}
