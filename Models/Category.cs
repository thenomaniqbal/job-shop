using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobShop.Models
{
    public class Category
    {
        public int id { get; set; }
        [Required(ErrorMessage = "You must mention the Type of Job to proceed:")]
        [Display(Name ="Type of Job")]
        public string categoryName { get; set; }
        [Required(ErrorMessage = "Category Description is Required:")]
        [Display(Name ="Category Description")]
        public string categoryDescription { get; set; }
        public virtual ICollection<Job> Job { get; set; }
    }
}