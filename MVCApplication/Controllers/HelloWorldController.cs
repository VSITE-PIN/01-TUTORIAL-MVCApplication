using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            Dog dog = new Dog();
            dog.Name = "Buddy";
            dog.Age = 3;
            return View(dog);
        }
        public string Hello()
        {
            return "Hello";
        }
        public IActionResult Create()
        {
            return View();
        }
    }   
}
