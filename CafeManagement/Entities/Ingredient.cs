using System;

namespace CafeManagement.Entities
{
    public class Ingredient
    {
        private String ingredientId;
        private String name;
        private String unit;
        private int quantity;
        private double unitPrice;

        public Ingredient(String ingredientId, String name, String unit, int quantity, double unitPrice)
        {
            this.ingredientId = ingredientId;
            this.name = name;
            this.unit = unit;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        public String getIngredientId() { return ingredientId; }
        public String getName() { return name; }
        public String getUnit() { return unit; }
        public int getQuantity() { return quantity; }
        public double getUnitPrice() { return unitPrice; }

        public void setIngredientId(String ingredientId) { this.ingredientId = ingredientId; }
        public void setName(String name) { this.name = name; }
        public void setUnit(String unit) { this.unit = unit; }
        public void setQuantity(int quantity) { this.quantity = quantity; }
        public void setUnitPrice(double unitPrice) { this.unitPrice = unitPrice; }
    }
}
