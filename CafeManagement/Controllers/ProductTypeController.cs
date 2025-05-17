using CafeManagement.Entities;
using CafeManagement.Services;
using System.Collections.Generic;

namespace CafeManagement.Controllers
{
    public class ProductTypeController
    {
        private ProductTypeService productTypeService;

        public ProductTypeController()
        {
            productTypeService = new ProductTypeService();
        }

        public bool AddProductType(string id, string name)
        {
            var type = new ProductType(id, name);
            return productTypeService.AddProductType(type);
        }

        public bool UpdateProductType(string id, string name)
        {
            var type = new ProductType(id, name);
            return productTypeService.UpdateProductType(type);
        }

        public bool DeleteProductType(string id)
        {
            return productTypeService.DeleteProductType(id);
        }

        public ProductType GetProductTypeById(string id)
        {
            return productTypeService.GetProductTypeById(id);
        }

        public List<ProductType> GetAllProductTypes()
        {
            return productTypeService.GetAllProductTypes();
        }
    }
}
