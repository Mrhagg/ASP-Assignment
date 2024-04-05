using System.ComponentModel.DataAnnotations;

namespace ASP.Models;

public class AccountDetailsAddressInfoModel
{

    [DataType(DataType.Text)]
    [Display(Name = "Addres line 1", Prompt = "Enter your first address line")]
    [Required(ErrorMessage = "A valid addressline is required")]
    
    public string Addressline_1 { get; set; } = null!;


    [DataType(DataType.Text)]
    [Display(Name = "Addres line 2 (optional)", Prompt = "Enter your second address line")]
    public string? Addressline_2 { get; set; }


    [DataType(DataType.Text)] 
    [Display(Name = "Postal code", Prompt = "Enter your postal code")]
    [Required(ErrorMessage = "A valid postal code is required")]
    public string PostalCode { get; set; } = null!;


    [DataType(DataType.Text)]
    [Display(Name = "City", Prompt = "Enter your city")]
    [Required(ErrorMessage = "A valid city is required")]
    public string City { get; set; } = null!;
}
