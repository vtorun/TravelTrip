using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        Context context = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult MesajGonder()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult MesajGonder(Iletisim iletisim)
        {
            context.Iletisims.Add(iletisim);
            context.SaveChanges();
            return PartialView();
        }

    }
}