using Microsoft.AspNetCore.Mvc;
using RazorPages.Models;

namespace RazorPages.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View(new MyModel
            {
                Message = "This iy my controller."
            });
        }
    }
}
