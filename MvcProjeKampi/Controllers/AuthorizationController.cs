using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthorizationController : Controller
    {
        // GET: Authorization
       AdminManager adminmanager = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var adminvalues=adminmanager.GetList();
            return View(adminvalues);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            List<SelectListItem> role=(from x in adminmanager.GetList()
                                       select new SelectListItem
                                       {
                                           Text=x.AdminRole,
                                           Value=x.AdminID.ToString(),
                                       }).ToList();


            ViewBag.adm = role;

            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            string sifre = Hash.Encrypt(p.AdminPassword);
            p.AdminPassword = sifre;
            adminmanager.AdminAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditAdmin(int id)
        {


            var adminvalue = adminmanager.GetByID(id);
            return View(adminvalue);
            
        }

        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
           


            adminmanager.AdminUpdate(p);
            return RedirectToAction("Index");
        }
    }
}