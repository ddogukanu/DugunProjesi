using dd_19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dd_19.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Slider()
        {
            return View();
        }

        public ActionResult Story()
        {
            return View();
        }

        public ActionResult Timer()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Wedding()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Rezervasyon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Rezervasyon(Rezervasyon r)
        {
            if(ModelState.IsValid)
            {
                r.IP = Request.ServerVariables["REMOTE_ADDR"];
                ApplicationDbContext ctx = new ApplicationDbContext();
                ctx.Rezervasyonlar.Add(r);
                ctx.SaveChanges();
                ViewBag.sonuc = "TesekkurEt();";
            }

            return View();
        }

    }
}