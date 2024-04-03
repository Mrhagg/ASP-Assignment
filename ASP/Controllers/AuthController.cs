using ASP.Contexts;
using ASP.Entities;
using ASP.Models;
using ASP.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.Controllers;

public class AuthController(ApplicationContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager) : Controller
{
    private readonly ApplicationContext _context = context;
    private readonly UserManager<ApplicationUser> _userManager = userManager;
    private readonly SignInManager<ApplicationUser> _signInManager = signInManager;



    [Route("/signup")]
    public IActionResult SignUp()
    {
        var viewModel = new SignUpViewModel();
        return View(viewModel);
    }




    [HttpPost]
    [Route("/signup")]
   
    public async Task<IActionResult> SignUp(SignUpViewModel viewModel)
    {

        if (ModelState.IsValid)
        {
            if (!await _context.Users.AnyAsync(x => x.Email == viewModel.Form.Email))
            {
                var applicationUser = new ApplicationUser
                {
                    FirstName = viewModel.Form.FirstName,
                    LastName = viewModel.Form.LastName,
                    Email = viewModel.Form.Email,
                    UserName = viewModel.Form.Email
                };


                var result = await _userManager.CreateAsync(applicationUser, viewModel.Form.Password);
                if (result.Succeeded)
                {
                   
                    return RedirectToAction("SignIn", "Auth");
                }
                else
                {
                    ViewData["StatusMessage"] = "Something went wrong. Try again later.";
                }
            }
            else
            {
                ViewData["StatusMessage"] = "User with same email already exists";
            }
        }

        return View(viewModel);

    }



    [HttpGet]
    [Route("/signin")]
    
    public IActionResult SignIn()
    {
        var viewModel = new SignInViewModel();
        return View(viewModel);
    }



    [HttpPost]
    [Route("/signin")]
    
    public async Task<IActionResult> SignIn(SignInViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var applicationuser = await _userManager.FindByEmailAsync(viewModel.Form.Email);
            if (applicationuser != null)
            {
                var result = await _signInManager.PasswordSignInAsync(applicationuser, viewModel.Form.Password, viewModel.Form.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Account");
                }
            }
        }
        viewModel.ErrorMessage = "Incorrect email or password";
        return View(viewModel);

    }
}
