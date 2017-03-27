using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_site.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserProfile()
        {
            return View();
        }

        public ActionResult TableList()
        {
            return View();
        }

        public ActionResult Typography()
        {
            return View();
        }

        public ActionResult Icons()
        {
            return View();
        }

        public ActionResult Maps()
        {
            return View();
        }

        public ActionResult Notification()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}