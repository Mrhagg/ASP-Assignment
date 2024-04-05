using ASP.Models;
namespace ASP.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = null!;
  
    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = null!;
}
