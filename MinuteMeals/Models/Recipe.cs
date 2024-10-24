using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace MinuteMeals.Models
{
    [Table(nameof(Recipe))]
    public class Recipe
    {
        public required string Name { get; set; }
        public required string Ingredients { get; set; }
        public required string Steps { get; set; }
        public int CookingTimeInMinutes { get; set; }
    }
}
