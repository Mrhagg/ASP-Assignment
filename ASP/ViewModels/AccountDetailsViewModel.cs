using ASP.Models;
namespace ASP.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";

    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
    {
        ProfileImage = "images/bruno.svg",
        FirstName = "William",
        LastName = "Hägg",
        Email = "william@domain.com"
    };

    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();


}
