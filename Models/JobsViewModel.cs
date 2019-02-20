using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobShop.Models
{
    public class JobsViewModel
    {
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Name is incorrect,Use letters only in Job Title please")]

        public string JobTitle { get; set; }
        public IEnumerable<ApplyForJob> items { get; set; }
    }
}