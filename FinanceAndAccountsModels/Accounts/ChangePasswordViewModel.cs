using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinanceAndAccountsModels.Accounts
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string OldPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Password must contain atleast one uppercase letter, one lowercase letter, one number and one special character.")]
        [Compare("ConfirmPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        [NotEqualWithLastThreePasswords(ErrorMessage = "The new password must not be the same as the last three passwords.")]
        public string NewPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class NotEqualWithLastThreePasswordsAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string newPassword = value as string;
            if (newPassword != null)
            {
                // Add logic to check if the new password is not the same as the last three passwords.
                // You can store the last three passwords in the database or in a cache, and compare with the new password.
                // If the new password is the same as any of the last three passwords, return false.
                // Otherwise, return true.
                return true;
            }
            return false;
        }
    }
}
