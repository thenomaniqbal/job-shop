using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobShop.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required(ErrorMessage = "Email Address is Required:")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email Adress")]
        public string Email { get; set; }
        [Display(Name = "Full Name")]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Name is incorrect,Use letters only in Full Name please")]

        public string FullName { get; set; }
        public string Gender { get; set; }
        [Display(Name = "User Name")]

        public string UserName { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required(ErrorMessage = "Email Address is Required:")]
        [EmailAddress]
        [Display(Name = "Email Adress")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email Address is Required:")]
        [Display(Name = "Email Adress")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        //[Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; }
        [Display(Name = "Full Name"), Required]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Name is incorrect,Use letters only in Full Name please")]

        public string FullName { get; set; }


        [Required(ErrorMessage = "Password is Required:")]
        [StringLength(105, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mobile Number")]
        [RegularExpression(@"^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$", ErrorMessage = "Not a valid Mobile number ,please enter a number with 11 digits")]
        public string PhoneNumber { get; set; }
        //public string RoleName { get; set; }

        //[Display(Name = "UserPhoto")]
        //public byte[] UserPhoto { get; set; }
        [Display(Name = "CompanyName")]
        [StringLength(100)]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Name is incorrect,Use letters only in Full Name please")]

        public string CompanyName { get; set; }
        [Display(Name = "CompanyId")]
        [StringLength(100)]
        public string CompanyId { get; set; }

    }
    public class EditProfileViewModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "User Name is Required")]
        [Display(Name = "User name")]
        public string username { get; set; }
        [Display(Name = "Full Name"), Required]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Name is incorrect,Use letters only in Full Name please")]

        public string FullName { get; set; }


        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        //[DataType(DataType.PhoneNumber)]
        //[Display(Name = "Mobile Number")]
        //[RegularExpression(@"^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$", ErrorMessage = "Not a valid Mobile number")]
        //public string PhoneNumber { get; set; }



        [Required(ErrorMessage = "You must enter Your Current Password To Proceed")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string CurrentPassword { get; set; }


        [Required(ErrorMessage = "Kindly! Enter New Password To Proceed")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("NewPassword", ErrorMessage = "The password and confirmation password do not match")]
        public string ConfirmPassword { get; set; }
    }


    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must enter Your  Password To Proceed")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
    }
}
