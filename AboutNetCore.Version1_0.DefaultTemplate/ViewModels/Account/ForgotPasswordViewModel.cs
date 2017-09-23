using System.ComponentModel.DataAnnotations;

namespace AboutNetCore.Version1_0.DefaultTemplate.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
