using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Microsoft.AspNet.Identity;
using JobShop.Models;
using JobShop.Migrations;

namespace JobShop.Controllers
{
    public class BlogsHomePageController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BlogsHomePage
        public ActionResult Index()
        {
            var blogs = db.BlogCategories.Include(j => j.Blogs);
            return View(db.BlogCategories.ToList());
        }
        //public ActionResult Search(string searchname)
        //{
        //    var result = db.Blogs.Where(a => a.BlogContent.Contains(searchname) || a.BlogerName.Contains(searchname) || a.BlogTitle.Contains(searchname)).ToList();

        //    return View(result);
        //}

        public ActionResult Details(int blogId)
        {
            var blog = db.Blogs.Find(blogId);
            if (blog == null)
            {
                return HttpNotFound();
            }
            Session["blogid"] = blogId;
            return View(blog);
        }
    }
}