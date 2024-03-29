using ASP.Helpers;
using System.ComponentModel.DataAnnotations;


namespace ASP.Models;

public class SignUpModel
{
    [DataType(DataType.Text)]
    [Display(Name = "First Name", Prompt = "Enter your first name")]
    [Required(ErrorMessage = "Enter a first name")]
    [MinLength(2, ErrorMessage = "Enter a first name")]
    public string FirstName { get; set; } = null!;


    [DataType(DataType.Text)]
    [Display(Name = "Last Name", Prompt = "Enter your last name")]
    [Required(ErrorMessage = "Enter a last name")]
    [MinLength(2, ErrorMessage = "Enter a last name")]

    public string LastName { get; set; } = null!;

    
    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Enter a valid email address")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Your email address is invalid")]
    public string Email { get; set; } = null!;


    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "Enter a valid password")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Invalid password, must be a strong password")]

    public string Password { get; set; } = null!;


    [DataType(DataType.Password)]
    [Display(Name = "Confirm password", Prompt = "Confirm your password", Order = 4)]
    [Required(ErrorMessage = "Password must be confirmed")]
    [Compare(nameof(Password), ErrorMessage = "Password must be confirmed")]
    public string ConfirmPassword { get; set; } = null!;


    [Display(Name = "I agree to the Terms & Conditions.", Order = 5)]
    [CheckBoxRequired(ErrorMessage = "You must accept the terms & conditions.")]
    public bool TermsAndCondition { get; set; } = false;

}




