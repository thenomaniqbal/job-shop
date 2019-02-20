using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobShop.Models
{

    [Table("employers")]
    public class Employer
    {
        [Key]
        public int EmployerId { get; set; }

        [Display(Name = "Full Name"), Required]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Name is incorrect,Use letters only in Full Name please")]
        [StringLength(100)]
        public string FullName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email Address is required")]
        [Display(Name = "Email Address")]
        [StringLength(200)]
        public string EmailAdress { get; set; }
        [DisplayFormat(NullDisplayText = "Gender not specified")]

        [StringLength(1)]
        public string Gender { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Age is required")]
        public string Age { get; set; }
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mobile Number")]
        [RegularExpression(@"^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$", ErrorMessage = "Not a valid Mobile number ,please enter a number with 11 digits")]

        public string PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Hired Date")]
        public DateTime? HireDate { get; set; }


        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "designation is required")]

        public string Designation { get; set; }

        [DataType(DataType.Currency)]

        [StringLength(100)]
        public string Salary { get; set; }

        [DataType(DataType.Url)]
        //[UIHint("OpenInNewWindow")]
        [StringLength(100)]
        [Required(ErrorMessage = "personal website is required")]

        public string PersonalWebsite { get; set; }

        [Required(ErrorMessage = "Company is required")]
        public string Company { get; set; }
        [Required(ErrorMessage = "Department is required")]

        public string Department { get; set; }

        [Display(Name = "Employer Image")]
        public string Photo { get; set; }

        public string UserId { get; set; }


    }

}

