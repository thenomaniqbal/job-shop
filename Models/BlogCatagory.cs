using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobShop.Models
{
    public class BlogCategory
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Blog Category Name is Required:")]
        [Display(Name = "Blog Category Name")]
        public string CatTitle { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}