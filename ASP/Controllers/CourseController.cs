using ASP.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ASP.Controllers;

[Authorize]
public class CourseController(HttpClient httpClient) : Controller
{
    private readonly HttpClient _httpClient = httpClient;

    [Route("/courses")]
    public async Task<IActionResult> Index()
    {
        var viewModel = new CourseIndexViewmodel();

        var response = await _httpClient.GetAsync("https://localhost:7219/api/Courses");

        if (response.IsSuccessStatusCode)
        {
            viewModel.Courses = JsonConvert.DeserializeObject<IEnumerable<CoursesViewmodel>>(await response.Content.ReadAsStringAsync())!;
        }
        return View(viewModel);
    }
}
