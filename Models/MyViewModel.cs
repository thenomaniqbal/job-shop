using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobShop.Models
{
    public class MyViewModel
    {
        [Required]
        [DisplayName("Select File to Upload")]
        public HttpPostedFileBase File { get; set; }

        [Display(Name = "Full Name")]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Name is incorrect,Use letters only in Full Name please")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Email Address is Required:")]
        [Display(Name = "Email Adress")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]

        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mobile Number")]
        [RegularExpression(@"^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$", ErrorMessage = "Not a valid Mobile number ,please enter a number with 11 digits")]

        public string PhoneNumber { get; set; }
        [DisplayName("Desired Job Title")]
        public string DesiredJobTitle { get; set; }



    }

    public class FileUploadDBModel
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] File { get; set; }
        public string FullName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DesiredJobTitle { get; set; }


    }
}