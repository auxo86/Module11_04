using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module11_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/TempDataDemo
        public ActionResult TempDataDemo()
        {
            ViewData["Key1"] = DateTime.Now.ToString();
            ViewBag.key2 = DateTime.Now.ToString();
            TempData["Key3"] = DateTime.Now.ToString();

            //return View();
            return RedirectToAction("TempDataDemo2");
        }

        // GET: Home/TempDataDemo2
        public ActionResult TempDataDemo2()
        {
            return View();
        }

        // GET: Home/SessionDemo
        public ActionResult SessionDemo()
        {
            if (Session["count"] == null)
                Session["count"] = 0;
            else
                Session["count"] = (int)Session["count"] + 1;

            return View();
        }
    }
}