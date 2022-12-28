using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        SkillManager talentManager = new SkillManager(new EfSkillDal());
        public ActionResult Index()
        {
            var result = talentManager.GetList();
            return View(result);
        }

       public ActionResult SkillCard()
        {
            var result = talentManager.GetList();
            return View(result);
        }
    }
}