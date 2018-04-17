using System.ComponentModel.DataAnnotations;

namespace SetupSeleniumeDocker.UI.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}