using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CafeManagement.Entities;
using CafeManagement.Services;
using CafeManagement.Utils;

namespace CafeManagement.Controllers
{
    public class IngredientController
    {
        private IngredientService ingredientService;

        public IngredientController()
        {
            ingredientService = new IngredientService();
        }

        public List<Ingredient> GetAllIngredients()
        {
            try
            {
                return ingredientService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Ingredient>();
            }
        }

        public Ingredient GetIngredientById(string id)
        {
            try
            {
                return ingredientService.GetById(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool AddIngredient(string name, string unit, int quantity, double unitPrice)
        {
            try
            {
                string id = Guid.NewGuid().ToString();
                Ingredient ingredient = new Ingredient(id, name, unit, quantity, unitPrice);
                ingredientService.Add(ingredient);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateIngredient(string id, string name, string unit, int quantity, double unitPrice)
        {
            try
            {
                Ingredient ingredient = new Ingredient(id, name, unit, quantity, unitPrice);
                ingredientService.Update(ingredient);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteIngredient(string id)
        {
            try
            {
                ingredientService.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateIngredientQuantity(string id, int quantityChange)
        {
            try
            {
                Ingredient ingredient = ingredientService.GetById(id);
                if (ingredient != null)
                {
                    int newQuantity = ingredient.getQuantity() + quantityChange;
                    if (newQuantity >= 0)
                    {
                        ingredient = new Ingredient(
                            ingredient.getIngredientId(),
                            ingredient.getName(),
                            ingredient.getUnit(),
                            newQuantity,
                            ingredient.getUnitPrice()
                        );
                        ingredientService.Update(ingredient);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Insufficient ingredient quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
