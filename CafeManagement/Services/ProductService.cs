using System;
using System.Collections.Generic;
using CafeManagement.DAO;
using CafeManagement.Entities;

namespace CafeManagement.Services
{
    public class ProductService
    {
        private ProductDAO productDAO;

        public ProductService()
        {
            productDAO = new ProductDAO();
        }

        public bool AddProduct(Product product)
        {
            try
            {
                if (string.IsNullOrEmpty(product.getId()) ||
                    string.IsNullOrEmpty(product.getName()) ||
                    string.IsNullOrEmpty(product.getType()))
                {
                    throw new ArgumentException("Please provide complete product information (ID, Name, Type).");
                }

                if (product.getImportPrice() < 0 || product.getSalePrice() < 0)
                {
                    throw new ArgumentException("Import price and sale price cannot be negative.");
                }

                Product existing = productDAO.GetProductById(product.getId());
                if (existing != null)
                {
                    Console.WriteLine("Product ID already exists.");
                    return false;
                }

                productDAO.AddProduct(product);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding product: " + ex.Message);
                return false;
            }
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                if (string.IsNullOrEmpty(product.getId()) ||
                    string.IsNullOrEmpty(product.getName()) ||
                    string.IsNullOrEmpty(product.getType()))
                {
                    throw new ArgumentException("Vui lòng nhập đầy đủ thông tin sản phẩm (ID, Tên, Loại).");
                }

                if (product.getImportPrice() < 0 || product.getSalePrice() < 0 || product.getQuantity() < 0)
                {
                    throw new ArgumentException("Giá nhập, giá bán và số lượng không được âm.");
                }

                Product existing = productDAO.GetProductById(product.getId());
                if (existing == null)
                {
                    Console.WriteLine("Không tìm thấy sản phẩm cần cập nhật.");
                    return false;
                }

                productDAO.UpdateProduct(product);
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

        public bool DeleteProduct(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    throw new ArgumentException("ID sản phẩm không được để trống.");
                }

                Product existing = productDAO.GetProductById(id);
                if (existing == null)
                {
                    Console.WriteLine("Không tìm thấy sản phẩm cần xóa.");
                    return false;
                }

                productDAO.DeleteProduct(id);
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

        public Product GetProductById(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    throw new ArgumentException("ID sản phẩm không được để trống.");
                }

                return productDAO.GetProductById(id);
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

        public List<Product> GetAllProducts()
        {
            try
            {
                return productDAO.GetAllProducts();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return null;
            }
        }

    }
}
