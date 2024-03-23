using ASP.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Controllers;

public class AuthController : Controller
{
    [Route ("/signup")]
    [HttpGet]
   public IActionResult SignUp()
    {
        var viewModel = new SignUpViewModel();
        return View(viewModel);
    }

    [Route("/signup")]
    [HttpPost]
    public IActionResult SignUp(SignUpViewModel viewModel)
    {
       
        return View(viewModel);
    }
}
