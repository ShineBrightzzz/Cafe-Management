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

        public bool AddProduct(string id, string name, string type, double importPrice, double salePrice, string image)
        {
            var product = new Product(id, name, type, importPrice, salePrice, image);
            return productService.AddProduct(product);
        }

        public bool UpdateProduct(string id, string name, string type, double importPrice, double salePrice, string image)
        {
            var product = new Product(id, name, type, importPrice, salePrice, image);
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
