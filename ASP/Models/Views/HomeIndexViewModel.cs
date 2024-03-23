using ASP.Models.Sections;

namespace ASP.Models.Views;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "";

    public ShowcaseViewModel Showcase { get; set; } = null!;
}
