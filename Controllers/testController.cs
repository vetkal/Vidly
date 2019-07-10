using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class testController : Controller
    {
        // GET: test
        public ActionResult Test()
        {
            ViewBag.Message = "This is my test page!";
            return View();
        }
    }
}