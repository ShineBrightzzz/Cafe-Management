using System;
using System.Collections.Generic;
using CafeManagement.DAO;
using CafeManagement.Entities;

namespace CafeManagement.Controllers
{
    public class SupplierController
    {
        private readonly SupplierDAO supplierDAO;

        public SupplierController()
        {
            supplierDAO = new SupplierDAO();
        }

        public bool AddSupplier(string id, string name, string phoneNumber, string address)
        {
            var supplier = new Supplier(id, name, phoneNumber, address);
            return supplierDAO.AddSupplier(supplier);
        }

        public bool UpdateSupplier(string id, string name, string phoneNumber, string address)
        {
            var supplier = new Supplier(id, name, phoneNumber, address);
            return supplierDAO.UpdateSupplier(supplier);
        }

        public bool DeleteSupplier(string id)
        {
            return supplierDAO.DeleteSupplier(id);
        }

        public Supplier GetSupplierById(string id)
        {
            return supplierDAO.GetSupplierById(id);
        }

        public List<Supplier> GetAllSuppliers()
        {
            return supplierDAO.GetAllSuppliers();
        }
    }
}
