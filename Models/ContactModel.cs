using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobShop.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Full Name is Required:")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name is incorrect,Use letters only in Full Name please")]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Address is Required:")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage="Subject is required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }
    }
}