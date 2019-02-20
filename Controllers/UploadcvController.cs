using JobShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobShop.Controllers
{
    public class UploadcvController : Controller
    {
        // GET: Uploadcv
        private ApplicationDbContext db = new ApplicationDbContext();



        public ActionResult Index()
        {
            return View(db.Cvs.ToList());
        }

        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(string baseData,Cv cv)
        {
            if (HttpContext.Request.Files.AllKeys.Any())
            {
                for (int i = 0; i <= HttpContext.Request.Files.Count; i++)
                {
                    var file = HttpContext.Request.Files["files" + i];
                    if (file != null)
                    {
                        var fileSavePath = Path.Combine(Server.MapPath("/Files"), file.FileName);
                        file.SaveAs(fileSavePath);
                    }
                }
            }
            return View(cv);
        }

        public ActionResult Download()
        {
            string[] files = Directory.GetFiles(Server.MapPath("/Files"));
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = Path.GetFileName(files[i]);
            }
            ViewBag.Files = files;
            return View();
        }

        public FileResult DownloadFile(string fileName)
        {
            var filepath = System.IO.Path.Combine(Server.MapPath("/Files/"), fileName);
            return File(filepath, MimeMapping.GetMimeMapping(filepath), fileName);
        }
    }
}