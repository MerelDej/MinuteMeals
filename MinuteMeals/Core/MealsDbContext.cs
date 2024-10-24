using Microsoft.EntityFrameworkCore;
using MinuteMeals.Models;
using System;

namespace MinuteMeals.Core

{
    public class MealsDbContext(DbContextOptions<MealsDbContext> options) : DbContext(options)
    {
        public DbSet<Recipe> Recipes => Set<Recipe>();

        public void Seed()
        {

            var meal = new List<Recipe>
            {
                new Recipe { Name = "Chicken Tikka Masala", Ingredients = "", Steps = "", CookingTimeInMinutes = 102 },
                new Recipe { Name = "Spaghetti Carbonara", Ingredients = "", Steps = "" },
                new Recipe { Name = "Chicken Fajitas", Ingredients = "", Steps = "" },
                new Recipe { Name = "Chicken Alfredo", Ingredients = "", Steps = "", CookingTimeInMinutes = 33 },
                new Recipe { Name = "Beef Wellington", Ingredients = "", Steps = "", CookingTimeInMinutes = 150 },
                new Recipe { Name = "Pulled Pork Sandwiches", Ingredients = "", Steps = "" },
                new Recipe { Name = "Pesto Pasta", Ingredients = "", Steps = "" },
                new Recipe { Name = "Paella", Ingredients = "", Steps = "" },
                new Recipe { Name = "Egg Fried Rice", Ingredients = "", Steps = "", CookingTimeInMinutes = 20 },
                new Recipe { Name = "Ratatouille", Ingredients = "", Steps = "", CookingTimeInMinutes = 90 }
            };

            Recipes.AddRange(meal);

            SaveChanges();
        }
    }
}
