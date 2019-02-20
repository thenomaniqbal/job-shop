using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobShop.Models
{
    public class BlogViewModel
    {
        public int id { get; set; }
        public int blogId { get; set; }
        public virtual Blog blog { get; set; }


    }
}