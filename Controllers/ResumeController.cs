using JobShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace JobShop.Controllers
{
    [Authorize]

    public class ResumeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var model = new MyViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(MyViewModel model)
        {

            if (!ModelState.IsValid)
            {
                ModelState.Clear();
            }

            FileUploadDBModel fileUploadModel = new FileUploadDBModel();

            byte[] uploadFile = new byte[model.File.InputStream.Length];
            model.File.InputStream.Read(uploadFile, 0, uploadFile.Length);

            fileUploadModel.FileName = model.File.FileName;
            fileUploadModel.File = uploadFile;
            fileUploadModel.FullName = model.FullName;
            fileUploadModel.Email = model.Email;
            fileUploadModel.PhoneNumber = model.PhoneNumber;
            fileUploadModel.DesiredJobTitle = model.DesiredJobTitle;

            db.FileUploadDBModels.Add(fileUploadModel);
            db.SaveChanges();
            ViewBag.message = "Dear User!You have Successfully uploaded your resume!";
            return View();

            //return Content("File Uploaded.");
        }
        public ActionResult Download()
        {
            return View(db.FileUploadDBModels.ToList());
        }
        public FileContentResult FileDownload(int? id)
        {
            byte[] fileData;
            string fileName;

            FileUploadDBModel fileRecord = db.FileUploadDBModels.Find(id);

            fileData = (byte[])fileRecord.File.ToArray();
            fileName = fileRecord.FileName;
            fileRecord.FullName = fileRecord.FullName;
            fileRecord.Email = fileRecord.Email;
            fileRecord.PhoneNumber = fileRecord.PhoneNumber;
            fileRecord.DesiredJobTitle = fileRecord.DesiredJobTitle;

            return File(fileData, "text", fileName);
        }
   
    }
}