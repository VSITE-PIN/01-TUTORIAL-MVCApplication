using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            Dog dog = new Dog();
            dog.Name = "Rex";
            dog.Age = 2;
            return View(dog);

        }
        public IActionResultI Create()
            {
            return View();
        }
    }
}
