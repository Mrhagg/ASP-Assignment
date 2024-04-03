using Microsoft.AspNetCore.Mvc;

namespace ASP.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Profile";
        return View();
    }

   

    
}
