using System.Diagnostics;
using AdminDashboard_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminDashboard_UI.Controllers
{
    public class HomeController : Controller
    {
        //Dependency Injection approach
        //constructor

        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult PasswordIncorrect()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterUser(string username, string email, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                ViewBag.ErrorMessage = "Passwords do not match";
                return View("PasswordIncorrect");
            }

            _context.Users.Add(new Users
            {
                Name = username,
                Email = email,
                Password = password,
                Role="User"
            });
            _context.SaveChanges();


            return RedirectToAction("Index");
        }
       
        
    }
}
