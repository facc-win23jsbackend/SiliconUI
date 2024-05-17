using System.ComponentModel.DataAnnotations;

namespace AccountUI.Models;

public class NotificationsFormModel
{
    public string UserId { get; set; } = null!;

    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Enter an valid email address")]
    [RegularExpression(@"^(([^<>()[\]\\.,;:\s@\""]+(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$", ErrorMessage = "Invalid email")]
    public string Email { get; set; } = null!;

    public bool SubscribeToNewsletter { get; set; }

}
