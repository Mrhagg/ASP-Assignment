﻿using ASP.Helpers;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ASP.Models;

public class SignUpModel
{
    [Display(Name = "First Name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "First name is required")]

    public string FirstName { get; set; } = null!;

    [Display(Name = "Last Name", Prompt = "Enter your last name", Order = 1)]
    [Required(ErrorMessage = "Last name is required")]

    public string LastName { get; set; } = null!;

    
    [Display(Name = "Email address", Prompt = "Enter your email address", Order = 2)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email is required")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Your email address is invalid")]

    public string Email { get; set; } = null!;

    

    [Display(Name = "Password", Prompt = "Password is required", Order = 3)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Invalid password")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Invalid password, must be a strong password")]
    public string Password { get; set; } = null!;


    [Display(Name = "Confirm password", Prompt = "Confirm your password", Order = 4)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password must be confirmed")]
    [Compare(nameof(Password), ErrorMessage = "Fields does not match")]
    public string ConfirmPassword { get; set; } = null!;


    [Display(Name = "I agree to the Terms & Conditions.", Order = 5)]
    [CheckBoxRequired(ErrorMessage = "You must accept the terms & conditions.")]
    public bool TermsAndCondition { get; set; } = false;

}




