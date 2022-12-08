using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        ShopContext db;
        public HomeController(ShopContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Employees.ToList());
        }
    }
}