using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        AboutManager am = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var aboutvalues = am.GetList();
            return View(aboutvalues);
        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();

        }

        [HttpPost]
        public ActionResult AddAbout(About p)
        {
            am.AboutAdd(p);
            return RedirectToAction("Index");

        }

        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }

        public ActionResult AboutStatu(int id)
        {
            var deger = am.GetByID(id);
            if (deger.AboutStatus == false)

            {
                deger.AboutStatus = true;


            }

            else
            {
                deger.AboutStatus = false;
            }

            am.AboutUpdate(deger);
            return RedirectToAction("Index");
        }
    }
}