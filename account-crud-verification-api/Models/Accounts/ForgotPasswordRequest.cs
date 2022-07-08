using System.ComponentModel.DataAnnotations;

namespace account_crud_verification_api.Models.Accounts
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
