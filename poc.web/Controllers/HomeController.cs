using poc.data.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace poc.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new pocDBContext())
            {
                db.Authors.Add(new data.Entities.Author {CreatedDate=DateTime.UtcNow, FirstName = "Marc", LastName = "Hemstreet", CreatedBy="system", Email="mhemstreet@meetveracity.com" });
                db.SaveChanges();
            }
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}