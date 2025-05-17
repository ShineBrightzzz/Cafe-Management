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
        private string type;
        private double importPrice;
        private double salePrice;
        private int quantity;
        private string image;

        public Product(string id, string name, string type, double importPrice, double salePrice, string image)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.importPrice = importPrice;
            this.salePrice = salePrice;
            this.image = image;
        }

        public string getId() => id;
        public void setId(string id) => this.id = id;

        public string getName() => name;
        public void setName(string name) => this.name = name;

        public string getType() => type;
        public void setType(string type) => this.type = type;

        public double getImportPrice() => importPrice;
        public void setImportPrice(double importPrice) => this.importPrice = importPrice;

        public double getSalePrice() => salePrice;
        public void setSalePrice(double salePrice) => this.salePrice = salePrice;

        public int getQuantity() => quantity;
        public void setQuantity(int quantity) => this.quantity = quantity;

        public string getImage() => image;
        public void setImage(string image) => this.image = image;
    }
}
