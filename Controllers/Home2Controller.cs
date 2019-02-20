using JobShop.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace JobShop.Controllers
{
    public class Home2Controller : Controller
   
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var list = db.Categories.ToList();
            return View(list);
        }
        public ActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(string searchname)
        {
            var result = db.Jobs.Where(a => a.jobTitle.Contains(searchname) || a.City.Contains(searchname) || a.Salary.Contains(searchname) || a.jobContent.Contains(searchname) || a.Category.categoryName.Contains(searchname) || a.Category.categoryDescription.Contains(searchname)).ToList();

            return View(result);
        }
        [Authorize]
        public ActionResult GetJobsByPublisher()
        {
            var UserId = User.Identity.GetUserId();
            var jobs = from app in db.ApplyForJobs
                       join job in db.Jobs
                       on app.jobId equals job.id
                       where job.User.Id == UserId
                       select app;
            var groudId = from j in jobs
                          group j by j.job.jobTitle
                          into gr
                          select new JobsViewModel
                          {
                              JobTitle = gr.Key,
                              items = gr
                          };

            return View(groudId.ToList());
        }
        public ActionResult Edit(int id)
        {
            var job = db.ApplyForJobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        [HttpPost]
        public ActionResult Edit(ApplyForJob job)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(job).State = System.Data.Entity.EntityState.Modified;
                    job.ApplyDate = DateTime.Now;
                    db.SaveChanges();
                    return RedirectToAction("GetJobsByUser");
                }

                return View(job);
            }
            catch
            {
                return View();
            }
        }
        // GET: Roles/Delete/5
        public ActionResult Delete(int id)
        {
            var job = db.ApplyForJobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);

        }

        // POST: Roles/Delete/5
        [HttpPost]
        public ActionResult Delete(ApplyForJob job)
        {
            try
            {
                var Myjob = db.ApplyForJobs.Find(job.id);
                db.ApplyForJobs.Remove(Myjob);
                db.SaveChanges();
                return RedirectToAction("GetJobsByUser");
            }
            catch
            {
                return View(job);
            }
        }

        public ActionResult Details(int jobId)
        {
            var job = db.Jobs.Find(jobId);
            if (job == null)
            {
                return HttpNotFound();
            }
            Session["jobid"] = jobId;
            return View(job);
        }
        [Authorize]
        [HttpGet]
        public ActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Apply(string Message)
        {
            var userId = User.Identity.GetUserId();
            var jobId = (int)Session["jobid"];

            var check = db.ApplyForJobs.Where(a => a.jobId == jobId && a.userId == userId).ToList();


            if (check.Count < 1)
            {
                var job = new ApplyForJob();
                job.userId = userId;
                job.jobId = jobId;
                job.Message = Message;
                job.ApplyDate = DateTime.Now;

                db.ApplyForJobs.Add(job);
                db.SaveChanges();
                ViewBag.Result = "you Appled Successfully !";
            }
            else
            {
                ViewBag.Result = "you Applied to this job !";
            }

            return View();
        }

        [Authorize]
        public ActionResult GetJobsByUser()
        {
            var userId = User.Identity.GetUserId();
            var job = db.ApplyForJobs.Where(a => a.userId == userId);
            return View(job.ToList());
        }
        public ActionResult DetailsOfJob(int id)
        {
            var job = db.ApplyForJobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }

            return View(job);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpGet]
        public ActionResult Contact()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactModel contact)
        {
            var mail = new MailMessage();
            var loginInfo = new NetworkCredential("njobshop@gmail.com", "njobshop123");
            mail.From = new MailAddress(contact.Email);
            mail.To.Add(new MailAddress("njobshop@gmail.com"));
            mail.Subject = contact.Subject;
            mail.IsBodyHtml = true;
            string body = "Sender Name: " + contact.Name + "<br>" + "Sender Email: " + contact.Email + "<br>" + "Email Address: " + contact.Subject + "<br>" + "Message Body: <b>" + contact.Message + "</b>";
            mail.Body = body;

            var smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = loginInfo;
            smtpClient.Send(mail);
            return RedirectToAction("Index");
        }
    }
}