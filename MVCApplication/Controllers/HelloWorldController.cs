using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<Dog> dogs = new List<Dog>();

        public IActionResult Index()
        {
            return View(dogs);
            Dog dog = new Dog();
            dog.Name = "Rex";
            dog.Age = 2;
            return View(dog);
        }
        public IActionResult Create()
        {
            Dog dog = new Dog();
            return View(dog);
        }
        public IActionResult CreateDog(Dog dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction("Index");
        }
        public string Hello()
        {
            return "Hello World";
        }
    }
}
