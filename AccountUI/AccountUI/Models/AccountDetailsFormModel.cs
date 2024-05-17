using System.ComponentModel.DataAnnotations;
namespace AccountUI.Models;

public class AccountDetailsFormModel
{
    public string UserId { get; set; } = null!;


    [Display(Name = "First name", Prompt = "Enter your first name")]
    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; } = null!;


    [Display(Name = "Last name", Prompt = "Enter your last name")]
    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; } = null!;


    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Enter an valid email address")]
    [RegularExpression(@"^(([^<>()[\]\\.,;:\s@\""]+(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$", ErrorMessage = "Invalid email")]
    public string Email { get; set; } = null!;


    [Display(Name = "Phone", Prompt = "Enter your phone number")]
    [Required(ErrorMessage = "Phone is required")]
    public string PhoneNumber { get; set; } = null!;


    [Display(Name = "Bio", Prompt = "Add a short bio...")]
    [DataType(DataType.MultilineText)]
    public string? Biography { get; set; }






    [Display(Name = "Address line 1", Prompt = "Enter your address line")]
    [Required(ErrorMessage = "Address line is required")]
    public string Addressline_1 { get; set; } = null!;


    [Display(Name = "Address line 2", Prompt = "Enter your second address line (optional)")]
    public string? Addressline_2 { get; set; }


    [Display(Name = "Postal Code", Prompt = "Enter your postal code")]
    [Required(ErrorMessage = "Postal code is required")]
    public string PostalCode { get; set; } = null!;


    [Display(Name = "City", Prompt = "Enter your City")]
    [Required(ErrorMessage = "City line is required")]
    public string City { get; set; } = null!;
}
