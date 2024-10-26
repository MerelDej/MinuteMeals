using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MinuteMeals.Models
{
    [Keyless]
    [Table(nameof(Recipe))]
    public class Recipe
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Ingredients { get; set; }
        public required string Steps { get; set; }
        public int CookingTimeInMinutes { get; set; }
    }
}
