using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobShop.Models
{
    public class Answer
    {
        public int ID { get; set; }

        [Display(Name = "Full Name")]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Name is incorrect,Use letters only in Full Name please")]
        public string Name { get; set; }
        public string Css { get; set; }


    }
}