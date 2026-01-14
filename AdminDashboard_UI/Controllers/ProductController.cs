using AdminDashboard_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminDashboard_UI.Controllers
{
    public class ProductController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProductItem(string productname, string description, int price, string color)
        {
            var newProduct = new Products
            {
                ProductName = productname,
                Description = description,
                Price = price,
                Color = color
            };
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("Dashboard", "Home");
        }

        public IActionResult DeleteProduct(int productid)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productid);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Dashboard", "Home");
        }
    }


}
