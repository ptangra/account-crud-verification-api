using System.ComponentModel.DataAnnotations;

namespace account_crud_verification_api.Models.Accounts
{
    public class ValidateResetTokenRequest
    {
        [Required]
        public string Token { get; set; }
    }
}
