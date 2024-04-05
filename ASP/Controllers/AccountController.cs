using ASP.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Controllers;

public class AccountController : Controller
{
  
    #region Details
    [HttpGet]
    [Route("/account/details")]
    public IActionResult Details()
    {
        var viewModel = new AccountDetailsViewModel();
        return View(viewModel);
    }
    #endregion


    #region [HttpPost] SaveBasicInfo
    [HttpPost]
    public IActionResult SaveBasicInfo(AccountDetailsViewModel viewModel)
    {
      if (TryValidateModel(viewModel.BasicInfo))
        {
           return RedirectToAction("Index", "Home");
        }
      return View("Details", viewModel);
    }
    #endregion


    #region [HttpPost] SaveAddressInfo
    [HttpPost]
    public IActionResult SaveAddressInfo(AccountDetailsViewModel viewModel)
    {
        if (TryValidateModel(viewModel.AddressInfo))
        {
            return RedirectToAction("Index", "Home");
        }
        return View("Details", viewModel);


    }
    #endregion

   
    
}
