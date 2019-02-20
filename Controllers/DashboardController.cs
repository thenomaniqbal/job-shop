using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobShop.Controllers
{
    [Authorize]

    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/
        public ActionResult AdminDashboard()
        {
            return View();
        }

        public ActionResult UserDashboard()
        {
            return View();
        }
        public ActionResult EmployerDashboard()
        {
            return View();
        }

    }
}
