using CafeManagement.Entities;
using CafeManagement.Services;
using System.Collections.Generic;

namespace CafeManagement.Controllers
{
    public class TableController
    {
        private TableService tableService;

        public TableController()
        {
            tableService = new TableService();
        }

        public bool AddTable(string id, string name, bool isOccupied)
        {
            var table = new Table(id, name, isOccupied);
            return tableService.AddTable(table);
        }

        public bool UpdateTable(string id, string name, bool isOccupied)
        {
            var table = new Table(id, name, isOccupied);
            return tableService.UpdateTable(table);
        }

        public bool DeleteTable(string id)
        {
            return tableService.DeleteTable(id);
        }

        public Table GetTableById(string id)
        {
            return tableService.GetTableById(id);
        }

        public List<Table> GetAllTables()
        {
            return tableService.GetAllTables();
        }

        public List<Table> GetTablesByOccupationStatus(bool isOccupied)
        {
            return tableService.GetTablesByOccupationStatus(isOccupied);
        }
    }
}
