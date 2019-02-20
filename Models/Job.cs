using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobShop.Models
{
    public class Job
    {
        public int id { get; set; }
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Name is incorrect,Use letters only in Job Name please")]
        [Required(ErrorMessage = "Please enter job name.")]
        [Display(Name = "Job Name")]
        public string jobTitle { get; set; }
        [Display(Name = "Job Description")]
        [Required(ErrorMessage = "Please enter a job discription.")]
        [AllowHtml]
        public string jobContent { get; set; }
        [Required(ErrorMessage = "Please enter salary.")]

        [Display(Name = "Salary")]
        [Range(0.00, 1000000.00)]
        public string Salary { get; set; }

        [Required(ErrorMessage = "Kindly enter a city name.")]


        [Display(Name = "City")]

        public string City { get; set; }
        [Display(Name = "Job Image")]
        public string jobImage { get; set; }
        [Display(Name = "Job Type")]
        [Required(ErrorMessage = "Please enter job type.")]

        public int categoryId { get; set; }
        public string UserId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}