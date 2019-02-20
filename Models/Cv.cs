using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobShop.Models
{
    [Table("cvs")]
    public class Cv
{
        [Key]
        public int CId { get; set; }
        [Display(Name = "File Name")]
        [StringLength(100)]
        public string FileName { get; set; }

        [Required(ErrorMessage = "Email Address is Required:")]
        [Display(Name = "Email Adress")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [StringLength(200)]
        public string Email { get; set; }
   
        [StringLength(200)]
        public string Address { get; set; }

     
        [StringLength(100)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mobile Number")]
        [RegularExpression(@"^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$", ErrorMessage = "Not a valid Mobile number ,please enter a number with 11 digits")]

        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string position { get; set; }
      
       
        [StringLength(250)]


        public string file { get; set; }
    
}

}
