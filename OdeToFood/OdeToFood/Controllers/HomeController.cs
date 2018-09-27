using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        //basic basic basic
        public IActionResult Index()
        {
            var restaurant = new Restaurant {Id = 1, Name = "My Restaurant"};
            
            //returns as json
            return new ObjectResult(restaurant);
        }

        public IActionResult Home()
        {
            //MVC - controller building model
            var restaurant = new Restaurant {Id = 1, Name = "My Restaurant"};

            //MVC - model carries info to view
            return View(restaurant);
        }
    }
}
