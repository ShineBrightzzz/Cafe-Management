using System;
using System.Collections.Generic;
using CafeManagement.DAO;
using CafeManagement.Entities;

namespace CafeManagement.Services
{
    public class ProductTypeService
    {
        private ProductTypeDAO productTypeDAO;

        public ProductTypeService()
        {
            productTypeDAO = new ProductTypeDAO();
        }

        public bool AddProductType(ProductType productType)
        {
            try
            {
                if (string.IsNullOrEmpty(productType.getId()) || string.IsNullOrEmpty(productType.getName()))
                {
                    throw new ArgumentException("Vui lòng nhập đầy đủ thông tin loại sản phẩm (ID và Tên).");
                }

                ProductType existing = productTypeDAO.GetProductTypeById(productType.getId());
                if (existing != null)
                {
                    Console.WriteLine("ID loại sản phẩm đã tồn tại.");
                    return false;
                }

                productTypeDAO.AddProductType(productType);
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi không xác định: {ex.Message}");
                return false;
            }
        }

        public bool UpdateProductType(ProductType productType)
        {
            try
            {
                if (string.IsNullOrEmpty(productType.getId()) || string.IsNullOrEmpty(productType.getName()))
                {
                    throw new ArgumentException("Vui lòng nhập đầy đủ thông tin loại sản phẩm (ID và Tên).");
                }

                ProductType existing = productTypeDAO.GetProductTypeById(productType.getId());
                if (existing == null)
                {
                    Console.WriteLine("Không tìm thấy loại sản phẩm cần cập nhật.");
                    return false;
                }

                productTypeDAO.UpdateProductType(productType);
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi không xác định: {ex.Message}");
                return false;
            }
        }

        public bool DeleteProductType(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    throw new ArgumentException("ID loại sản phẩm không được để trống.");
                }

                ProductType existing = productTypeDAO.GetProductTypeById(id);
                if (existing == null)
                {
                    Console.WriteLine("Không tìm thấy loại sản phẩm cần xóa.");
                    return false;
                }

                productTypeDAO.DeleteProductType(id);
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi không xác định: {ex.Message}");
                return false;
            }
        }

        public ProductType GetProductTypeById(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    throw new ArgumentException("ID loại sản phẩm không được để trống.");
                }

                return productTypeDAO.GetProductTypeById(id);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi không xác định: {ex.Message}");
                return null;
            }
        }

        public List<ProductType> GetAllProductTypes()
        {
            try
            {
                return productTypeDAO.GetAllProductTypes();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return null;
            }
        }

    }
}
