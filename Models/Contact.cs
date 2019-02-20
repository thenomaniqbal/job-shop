using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobShop.Models
{
    [Table("Contacts")]

    public class Contact
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Full Name is Required:")]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Name is incorrect,Use letters only in Full Name please")]
        public string FullName { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Email Address is Required:")]
        [Display(Name = "Email Adress")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [StringLength(1000), Required]
        public string Message { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Mobile Number is Required:")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mobile Number")]
        [RegularExpression(@"^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$", ErrorMessage = "Not a valid Mobile number ,please enter a number with 11 digits")]
        public string PhoneNumber { get; set; }

    }

}