using System;

namespace CafeManagement.Entities
{
    public class Table
    {
        private string id;
        private string name;
        private bool isOccupied;

        public Table(string id, string name, bool isOccupied)
        {
            this.id = id;
            this.name = name;
            this.isOccupied = isOccupied;
        }

        public string getId()
        {
            return id;
        }

        public void setId(string id)
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

        public bool getIsOccupied()
        {
            return isOccupied;
        }

        public void setIsOccupied(bool isOccupied)
        {
            this.isOccupied = isOccupied;
        }

        // Helper method to get status as string for UI display
        public string getStatusString()
        {
            return isOccupied ? "Occupied" : "Available";
        }
    }
}
