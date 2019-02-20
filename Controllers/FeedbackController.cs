using JobShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace JobShop.Controllers
{

    public class FeedbackController : Controller
    {
        ApplicationDbContext context;
        public FeedbackController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Feedback
        public ActionResult Index()
        {
            return View(context.Feedbacks.ToList());
        }

        public ActionResult Create()
        {
            FeedbackViewModel model = new FeedbackViewModel();
            model.Answers = Common.GetAnswers();
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> Create(FeedbackViewModel model)
        {
            if (ModelState.IsValid)
            {
                context.Feedbacks.Add(new Feedback() { Answer = model.Select, Comment = model.Comment, Email = model.Email, FullName = model.FullName });
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}