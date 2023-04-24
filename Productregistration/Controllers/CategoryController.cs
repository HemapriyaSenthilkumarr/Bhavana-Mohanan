using Microsoft.AspNetCore.Mvc;
using Productregistration.Data;
using Productregistration.Models;

namespace Productregistration.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        
        //constructor to initialize the ApplicationDbContext instance for database operations
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
    
        //Returns a view containing a list of all the category objects in the database
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;  
            return View(objCategoryList);
        }

    }
}
