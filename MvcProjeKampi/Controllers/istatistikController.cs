using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcProjeKampi.Controllers
{
    public class istatistikController : Controller
    {
        // GET: istatistik
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        Context c=new Context();
       

        public ActionResult Index()
        {

            ViewBag.sorgu1 = c.Categories.Count();
            ViewBag.sorgu2=c.Headings.Count(x=>x.CategoryId==9);
            ViewBag.sorgu3 = c.Writers.Count(x => x.WriterName.Contains("a"));
            ViewBag.sorgu4 = cm.GetList().Where(x => x.CategoryId == (cm.GetList()
            .GroupBy(h => h.CategoryId).OrderByDescending(z => z.Count()).Select(y => y.Key)
            .FirstOrDefault())).Select(k => k.CategoryName).FirstOrDefault();

            int truedeger=c.Categories.Where(x=>x.CategoryStatus==true).Count();
            int falsedeger=c.Categories.Where(x=>x.CategoryStatus==false).Count();

            ViewBag.sorgu5 = truedeger - falsedeger;

            //Linq Sorgular yapıldı.

            //en fazla baslıga sahip kategorı adı



            return View();
        }
    }
}