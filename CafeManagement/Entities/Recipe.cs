using System;

namespace CafeManagement.Entities
{
    public class Recipe
    {
        private String recipeId;
        private String productId;
        private String ingredientId;
        private double amount;

        public Recipe(String recipeId, String productId, String ingredientId, double amount)
        {
            this.recipeId = recipeId;
            this.productId = productId;
            this.ingredientId = ingredientId;
            this.amount = amount;
        }

        public String getRecipeId() { return recipeId; }
        public String getProductId() { return productId; }
        public String getIngredientId() { return ingredientId; }
        public double getAmount() { return amount; }

        public void setRecipeId(String recipeId) { this.recipeId = recipeId; }
        public void setProductId(String productId) { this.productId = productId; }
        public void setIngredientId(String ingredientId) { this.ingredientId = ingredientId; }
        public void setAmount(double amount) { this.amount = amount; }
    }
}
