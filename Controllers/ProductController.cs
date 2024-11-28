using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductLab_2.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            ViewData["V1"] = "I am v1 created in index using ViewData";
            ViewBag.v2 = "I am v2 created in index using ViewBag";
            TempData["V3"] = "I am v3 created in index using TempData";
            Session["V4"] = "I am v4 created in index using session";
            return RedirectToAction("Display");
        }
        public ActionResult Display()
        {
            ViewData["V1"] = ViewData["V1"] + " inner ViewData";
            ViewBag.v2 = ViewBag.v2 + " inner ViewBag";
            TempData["V3"] = TempData["V3"] + " inner TempData";
            Session["V4"] = Session["V4"] + "  inner Session";

            return View();  
        }
        public ActionResult Show()
        {
            return View();
        }
    }
}