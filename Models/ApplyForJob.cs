using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobShop.Models;

namespace JobShop.Models
{
    public class ApplyForJob
    {
        public int id { get; set; }
        public string Message { get; set; }
        public DateTime ApplyDate { get; set; }
        public int jobId { get; set; }
        public string userId { get; set; }
        public virtual Job job { get; set; }
        public virtual ApplicationUser user { get; set; }
    }
}