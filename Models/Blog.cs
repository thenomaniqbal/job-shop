using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobShop.Models
{
    public class Blog
    {
        [Display(Name = "Blog Number")]

        public int id { get; set; }
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Please enter a blog title.")]
        public string BlogTitle { get; set; }
        [Display(Name = "Author")]
        [Required(ErrorMessage = "Please enter your name.")]
        public string BlogerName { get; set; }
        [Display(Name = "Content")]
        [Required(ErrorMessage = "Please write a blog.")]
        public string BlogContent { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]

        public string BlogerEmailId { get; set; }
        [Display(Name = "Blog Image")]

        public string BlogImage { get; set; }
        [Required(ErrorMessage = "Please enter The date.")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }


        [Display(Name = "blog Type")]
        public int blogcategoryId { get; set; }
        public string UserId { get; set; }
        public virtual BlogCategory BlogCategory { get; set; }

    }
}