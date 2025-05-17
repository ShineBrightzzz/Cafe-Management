using System;
using System.Collections.Generic;
using CafeManagement.DAO;
using CafeManagement.Entities;

namespace CafeManagement.Services
{
    public class TableService
    {
        private TableDAO tableDAO;

        public TableService()
        {
            tableDAO = new TableDAO();
        }

        public bool AddTable(Table table)
        {
            try
            {
                ValidateTable(table);
                tableDAO.AddTable(table);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddTable Service Error: " + ex.Message);
                return false;
            }
        }

        public bool UpdateTable(Table table)
        {
            try
            {
                ValidateTable(table);
                tableDAO.UpdateTable(table);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateTable Service Error: " + ex.Message);
                return false;
            }
        }

        public bool DeleteTable(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                    throw new ArgumentException("Table ID cannot be empty");
                
                tableDAO.DeleteTable(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("DeleteTable Service Error: " + ex.Message);
                return false;
            }
        }

        public Table GetTableById(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException("Table ID cannot be empty");
            
            return tableDAO.GetTableById(id);
        }

        public List<Table> GetAllTables()
        {
            return tableDAO.GetAllTables();
        }

        public List<Table> GetTablesByOccupationStatus(bool isOccupied)
        {
            return tableDAO.GetTablesByOccupationStatus(isOccupied);
        }

        private void ValidateTable(Table table)
        {
            if (table == null)
                throw new ArgumentNullException(nameof(table), "Table cannot be null");
            
            if (string.IsNullOrEmpty(table.getId()))
                throw new ArgumentException("Table ID cannot be empty");
            
            if (string.IsNullOrEmpty(table.getName()))
                throw new ArgumentException("Table name cannot be empty");
        }
    }
}
