using System.ComponentModel.DataAnnotations;

namespace ASP.Models
{
    public class AccountDetailsBasicInfoModel
    {
        public string UserId { get; set; } = null!;


        [DataType(DataType.Text)]
        [Display(Name = "First Name", Prompt = "Enter your first name")]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; } = null!;


        [DataType(DataType.Text)]
        [Display(Name = "Last Name", Prompt = "Enter your last name")]
        [Required(ErrorMessage = "Last name is required")]

        public string LastName { get; set; } = null!;


        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address", Prompt = "Enter your email address")]
        [Required(ErrorMessage = "Email is required")]
       
        public string Email { get; set; } = null!;



        [Display(Name = "Phone (optional)", Prompt = "Enter your Phone")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; } = null!;


        [DataType(DataType.MultilineText)]
        [Display(Name = "Bio (optional)", Prompt = "Add a short bio...")]
        public string? Biography { get; set; }
    }
}
