using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class TravelController : Controller
    {
        // GET: Travel
        Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Blogs.Take(10).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = context.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = context.Blogs.Where(x => x.ID == 2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult PartialTop10()
        {
            var degerler = context.Blogs.OrderByDescending(x => x.ID).Take(10).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult PartialBestPlaces()
        {
            var degerler = context.Blogs.OrderByDescending(x => x.ID).Take(6).ToList();
            return PartialView(degerler);
        }
    }
}