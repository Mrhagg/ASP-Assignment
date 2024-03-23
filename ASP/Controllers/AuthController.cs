using Microsoft.AspNetCore.Mvc;

namespace ASP.Controllers;

public class AuthController : Controller
{
    [Route ("/signup")]
   public IActionResult SignUp()
    {
        return View();
    }
}
