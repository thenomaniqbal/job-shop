using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobShop.Models
{
    public class Feedback
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int Answer { get; set; }
        [StringLength(500)]
        public string Comment { get; set; }

        [StringLength(100)]
        [Display(Name = "Full Name")]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Name is incorrect,Use letters only in Full Name please")]
        public string FullName { get; set; }

        [StringLength(255)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

    }
}