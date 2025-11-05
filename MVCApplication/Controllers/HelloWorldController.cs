using MVCApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class HelloWorldController : Controller
{
    private static readonly List<Dog> _dogs = new List<Dog>();

    public IActionResult Index()
    {
        return View(_dogs);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateDog(Dog dog)
    {
        if (!ModelState.IsValid) return View("Create", dog);
        _dogs.Add(dog);
        return RedirectToAction(nameof(Index));
    }

    public string Hello() => "Hello";
}
