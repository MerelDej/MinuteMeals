using Microsoft.AspNetCore.Mvc;
using MinuteMeals.Core;
using MinuteMeals.Models;

namespace MinuteMeals.Controllers
{
    public class MealsController : Controller
    {
        private readonly MealsDbContext _mealsDbContext;

        public MealsController(MealsDbContext mealsDbContext)
        {
            _mealsDbContext = mealsDbContext;
        }

        public IActionResult Index()
        {
            var meals = _mealsDbContext.Recipes.ToList();

            return View(meals);
        }
    }
}
