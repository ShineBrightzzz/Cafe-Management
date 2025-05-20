using System;
using System.Collections.Generic;
using CafeManagement.DAO;
using CafeManagement.Entities;

namespace CafeManagement.Services
{
    public class RecipeService
    {
        private RecipeDAO recipeDAO;

        public RecipeService()
        {
            recipeDAO = new RecipeDAO();
        }

        public List<Recipe> GetAll()
        {
            try
            {
                return recipeDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting recipes: " + ex.Message);
            }
        }

        public List<Recipe> GetByProductId(string productId)
        {
            try
            {
                return recipeDAO.GetByProductId(productId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting recipes for product: " + ex.Message);
            }
        }

        public void Add(Recipe recipe)
        {
            try
            {
                recipeDAO.Add(recipe);
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding recipe: " + ex.Message);
            }
        }

        public void Update(Recipe recipe)
        {
            try
            {
                recipeDAO.Update(recipe);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating recipe: " + ex.Message);
            }
        }

        public void Delete(string recipeId)
        {
            try
            {
                recipeDAO.Delete(recipeId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting recipe: " + ex.Message);
            }
        }

        public void DeleteByProduct(string productId)
        {
            try
            {
                recipeDAO.DeleteByProduct(productId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting product recipes: " + ex.Message);
            }
        }
    }
}
