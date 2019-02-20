using JobShop.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //
        //Faq
        public ActionResult Faq()
        {
            return View();
        }
        //
        //PrivacyPolicy
        public ActionResult PrivacyPolicy()
        {
            return View();
        }


        //public string Index()
        //{
        //    return "welcome to the job shop";
        //}
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [CustomAuthorize(Roles = " User")]//nomaniqbal
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [CustomAuthorize(Roles = "Admin")]//jobshop
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        //public FileContentResult UserPhotos()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        String userId = User.Identity.GetUserId();

        //        if (userId == null)
        //        {
        //            string fileName = HttpContext.Server.MapPath(@"~/Images/noImg.png");

        //            byte[] imageData = null;
        //            FileInfo fileInfo = new FileInfo(fileName);
        //            long imageFileLength = fileInfo.Length;
        //            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        //            BinaryReader br = new BinaryReader(fs);
        //            imageData = br.ReadBytes((int)imageFileLength);

        //            return File(imageData, "image/png");

        //        }
        //        // to get the user details to load user Image
        //        var bdUsers = HttpContext.GetOwinContext().Get<ApplicationDbContext>();
        //        var userImage = bdUsers.Users.Where(x => x.Id == userId).FirstOrDefault();

        //        return new FileContentResult(userImage.UserPhoto, "image/jpeg");
        //    }
        //    else
        //    {
        //        string fileName = HttpContext.Server.MapPath(@"~/Images/noImg.png");

        //        byte[] imageData = null;
        //        FileInfo fileInfo = new FileInfo(fileName);
        //        long imageFileLength = fileInfo.Length;
        //        FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        //        BinaryReader br = new BinaryReader(fs);
        //        imageData = br.ReadBytes((int)imageFileLength);
        //        return File(imageData, "image/png");

        //    }
        //}


    }
}