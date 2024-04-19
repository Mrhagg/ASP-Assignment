using Microsoft.AspNetCore.Mvc;

namespace ASP.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
