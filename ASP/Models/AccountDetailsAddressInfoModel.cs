using System.ComponentModel.DataAnnotations;

namespace ASP.Models;

public class AccountDetailsAddressInfoModel
{

    [DataType(DataType.Text)]
    [Display(Name = "First Name", Prompt = "Enter your first name")]
    [Required(ErrorMessage = "First name is required")]
    [MinLength(2, ErrorMessage = "First name is required")]
    public string Addressline_1 { get; set; } = null!;


    [DataType(DataType.Text)]
    [Display(Name = "Last Name", Prompt = "Enter your last name")]
    [Required(ErrorMessage = "Last name is required")]
    [MinLength(2, ErrorMessage = "Last name is required")]

    public string? Addressline_2 { get; set; }

    [DataType(DataType.PostalCode)] 
    [Display(Name = "Postal code", Prompt = "Enter your postal code")]
    [Required(ErrorMessage = "Postal code is required")]

    public string PostalCode { get; set; } = null!;


    [DataType(DataType.Text)]
    [Display(Name = "City", Prompt = "Enter your city")]
    [Required(ErrorMessage = "City is required")]
    public string City { get; set; } = null!;
}
