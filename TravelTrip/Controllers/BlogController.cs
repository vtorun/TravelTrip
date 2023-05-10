using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();
        public ActionResult Index()
        {
            //var degerler = context.Blogs.ToList();
            blogYorum.blog = context.Blogs.ToList();
            blogYorum.sonBloglar = context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            blogYorum.SonYorumlar = context.Yorumlars.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(blogYorum);
        }
        BlogYorum blogYorum = new BlogYorum();
        public ActionResult BlogDetay(int id)
        {
            //var blogBul = context.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.blog = context.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.yorum = context.Yorumlars.Where(x => x.BlogID == id).ToList();
            return View(blogYorum);
        }
    }
}