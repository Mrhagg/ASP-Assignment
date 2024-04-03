using ASP.Helpers;
using ASP.Models;
using System.ComponentModel.DataAnnotations;

namespace ASP.ViewModels;

public class SignUpViewModel
{
    public string Title { get; set; } = "Sign up";

    public SignUpModel Form { get; set; } = new SignUpModel();


}
