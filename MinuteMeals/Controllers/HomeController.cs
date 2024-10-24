using Microsoft.AspNetCore.Mvc;
using MinuteMeals.Models;
using MinuteMeals.Core;
using System.Diagnostics;

namespace MinuteMeals.Controllers
{
    public class HomeController : Controller
    {
        private readonly MealsDbContext _mealsDbContext;

        public HomeController(MealsDbContext mealsDbContext)
        {
            _mealsDbContext = mealsDbContext;
        }

        public IActionResult Index()
        {
            var meals = _mealsDbContext.Recipes.ToList();
            return View(meals);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
