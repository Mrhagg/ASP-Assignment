using Microsoft.AspNetCore.Mvc;

namespace ASP.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Contact Us!";
            return View();
        }
    }
}
