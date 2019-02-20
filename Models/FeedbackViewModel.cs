using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobShop.Models
{
    public class FeedbackViewModel
    {
        public string Comment { get; set; }

        [Display(Name = "Full Name")]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Name is incorrect,Use letters only in Full Name please")]
        public string FullName { get; set; }
        public int Select { get; set; }

        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        public List<Answer> Answers { get; set; }

    }
}