using System.ComponentModel.DataAnnotations;

namespace ASP.Models
{
    public class AccountDetailsBasicInfoModel
    {

        [DataType(DataType.ImageUrl)]
        public string? ProfileImage { get; set; }


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
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Your email address is invalid")]
        public string Email { get; set; } = null!;



        [Display(Name = "Phone", Prompt = "Enter your Phone")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone is required")]
        [MinLength(15, ErrorMessage = "Enter a valid didgit")]
        public string Phone { get; set; } = null!;



        [DataType(DataType.MultilineText)]
        [Display(Name = "Bio", Prompt = "Add a short bio...")]
        public string? Biography { get; set; }
    }
}
