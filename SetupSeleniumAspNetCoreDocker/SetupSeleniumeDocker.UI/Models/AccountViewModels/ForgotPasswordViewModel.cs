using System.ComponentModel.DataAnnotations;

namespace SetupSeleniumeDocker.UI.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}