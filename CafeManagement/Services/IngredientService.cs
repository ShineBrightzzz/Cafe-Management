using System;
using System.Collections.Generic;
using CafeManagement.DAO;
using CafeManagement.Entities;

namespace CafeManagement.Services
{
    public class IngredientService
    {
        private IngredientDAO ingredientDAO;

        public IngredientService()
        {
            ingredientDAO = new IngredientDAO();
        }

        public List<Ingredient> GetAll()
        {
            try
            {
                return ingredientDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting ingredients: " + ex.Message);
            }
        }

        public Ingredient GetById(string id)
        {
            try
            {
                return ingredientDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting ingredient: " + ex.Message);
            }
        }

        public void Add(Ingredient ingredient)
        {
            try
            {
                ingredientDAO.Add(ingredient);
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding ingredient: " + ex.Message);
            }
        }

        public void Update(Ingredient ingredient)
        {
            try
            {
                ingredientDAO.Update(ingredient);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating ingredient: " + ex.Message);
            }
        }

        public void Delete(string id)
        {
            try
            {
                ingredientDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting ingredient: " + ex.Message);
            }
        }
    }
}
