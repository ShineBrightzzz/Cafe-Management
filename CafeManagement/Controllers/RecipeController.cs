using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CafeManagement.Entities;
using CafeManagement.Services;
using CafeManagement.Utils;

namespace CafeManagement.Controllers
{
    public class RecipeController
    {
        private readonly RecipeService recipeService;
        private readonly ProductController productController;
        private readonly IngredientController ingredientController;

        public RecipeController()
        {
            recipeService = new RecipeService();
            productController = new ProductController();
            ingredientController = new IngredientController();
        }

        public List<Recipe> GetAllRecipes()
        {
            try
            {
                return recipeService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Recipe>();
            }
        }

        public List<Recipe> GetRecipesByProduct(string productId)
        {
            try
            {
                return recipeService.GetByProductId(productId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Recipe>();
            }
        }

        public bool AddRecipe(string productId, string ingredientId, double amount)
        {
            try
            {
                // Verify product and ingredient exist
                var product = productController.GetProductById(productId);
                var ingredient = ingredientController.GetIngredientById(ingredientId);
                
                if (product == null || ingredient == null)
                {
                    MessageBox.Show("Product or Ingredient not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string recipeId = Guid.NewGuid().ToString();
                Recipe recipe = new Recipe(recipeId, productId, ingredientId, amount);
                recipeService.Add(recipe);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateRecipe(string recipeId, string productId, string ingredientId, double amount)
        {
            try
            {
                // Verify product and ingredient exist
                var product = productController.GetProductById(productId);
                var ingredient = ingredientController.GetIngredientById(ingredientId);
                
                if (product == null || ingredient == null)
                {
                    MessageBox.Show("Product or Ingredient not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Recipe recipe = new Recipe(recipeId, productId, ingredientId, amount);
                recipeService.Update(recipe);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteRecipe(string recipeId)
        {
            try
            {
                recipeService.Delete(recipeId);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteRecipesByProduct(string productId)
        {
            try
            {
                recipeService.DeleteByProduct(productId);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CheckIngredientAvailability(string productId, int quantity)
        {
            try
            {
                var recipes = GetRecipesByProduct(productId);
                foreach (var recipe in recipes)
                {
                    var ingredient = ingredientController.GetIngredientById(recipe.getIngredientId());
                    if (ingredient == null)
                    {
                        return false;
                    }

                    double requiredAmount = recipe.getAmount() * quantity;
                    if (ingredient.getQuantity() < requiredAmount)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateIngredientsStock(string productId, int quantity)
        {
            try
            {
                var recipes = GetRecipesByProduct(productId);
                foreach (var recipe in recipes)
                {
                    double amountToReduce = recipe.getAmount() * quantity;
                    if (!ingredientController.UpdateIngredientQuantity(recipe.getIngredientId(), -(int)amountToReduce))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
