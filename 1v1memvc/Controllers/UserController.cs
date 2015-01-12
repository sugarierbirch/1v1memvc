using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1v1memvc.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserLanding()
        {
            ViewBag.UserName = "Jacob Callahan";
            return View();
        }
    }
}
