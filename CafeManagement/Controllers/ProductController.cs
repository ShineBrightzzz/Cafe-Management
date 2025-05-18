using CafeManagement.Entities;
using CafeManagement.Services;
using System.Collections.Generic;

namespace CafeManagement.Controllers
{
    public class ProductController
    {
        private ProductService productService;

        public ProductController()
        {
            productService = new ProductService();
        }

        public bool AddProduct(string id, string name, string typeId, double importPrice, double salePrice, int quantity, string image)
        {
            var product = new Product(id, name, typeId, importPrice, salePrice, quantity, image);
            return productService.AddProduct(product);
        }

        public bool UpdateProduct(string id, string name, string typeId, double importPrice, double salePrice, int quantity, string image)
        {
            var product = new Product(id, name, typeId, importPrice, salePrice, quantity, image);
            return productService.UpdateProduct(product);
        }

        public bool DeleteProduct(string id)
        {
            return productService.DeleteProduct(id);
        }

        public Product GetProductById(string id)
        {
            return productService.GetProductById(id);
        }

        public List<Product> GetAllProducts()
        {
            return productService.GetAllProducts();
        }
    }
}
