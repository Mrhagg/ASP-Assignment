using ASP.Models.Sections;
using ASP.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Task Managment Assistant You Gonna Love";

        var viewModel = new HomeIndexViewModel
        {
            Title = "Task Managment Assistant You Gonna Love",
            Showcase = new ShowcaseViewModel
            {
                Id = "overview",
                ShowcaseImage = new() { ImageUrl = "images/Background-image.svg", AltText = "Task Managment Assistant" },
                Title = "Task Managment Assistant You Gonna Love",
                Text = "We offer you a new generation of task managment system. Plan, manage & track all your tasks in one flexible tool.",
                Link = new() { ControllerName = "Downloads", ActionName = "Index", Text = "Get started for free" },
                BrandText = "Largest companies use our tool to work efficiently ",

                Brands =
                [
                    new() {ImageUrl = "images/Brand1.svg", AltText = "Brand Name 1"},
                    new() {ImageUrl = "images/Brand2.svg", AltText = "Brand Name 2"},
                    new() {ImageUrl = "images/Brand3.svg", AltText = "Brand Name 3"},
                    new() {ImageUrl = "images/Brand4.svg", AltText = "Brand Name 4"},
                ],



            }
        };

        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }
}