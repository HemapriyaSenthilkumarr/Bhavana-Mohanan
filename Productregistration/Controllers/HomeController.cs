using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Productregistration.Data;
using Productregistration.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;

namespace Productregistration.Controllers
{
    //constructor to initialize the logger and the database context
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        //Action method to display the home page
        public IActionResult Index()
        {
            return View();
        }

        //action method to dispalay the category page with list of categories
        public IActionResult Category()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
        //Action method to form submission to add a new category 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Category");
            }
            return View();
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