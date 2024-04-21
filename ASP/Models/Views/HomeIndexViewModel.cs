using ASP.Models.Sections;
using ASP.ViewModels;

namespace ASP.Models.Views;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "";

    public ShowcaseViewModel Showcase { get; set; } = null!;

    public SubscribeViewModel Subscribe { get; set; } = null!;
}