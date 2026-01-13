using Microsoft.AspNetCore.Mvc;

namespace AdminDashboard_UI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
