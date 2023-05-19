using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Blogsil(int id)
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var blog = context.Blogs.Find(id);
            return View("BlogGetir", blog);
        }
        public ActionResult BlogGuncelle(Blog blog)
        {
            var blogDegerler = context.Blogs.Find(blog.ID);
            blogDegerler.Aciklama = blog.Aciklama;
            blogDegerler.Baslik = blog.Baslik;
            blogDegerler.Tarih = blog.Tarih;
            blogDegerler.BlogImage = blog.BlogImage;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = context.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var yorum = context.Yorumlars.Find(id);
            context.Yorumlars.Remove(yorum);
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yorum = context.Yorumlars.Find(id);
            return View("YorumGetir", yorum);
        }
        public ActionResult YorumGuncelle(Yorumlar yorumlar)
        {
            var yorum = context.Yorumlars.Find(yorumlar.ID);
            yorum.KullaniciAdi = yorumlar.KullaniciAdi;
            yorum.Maill = yorumlar.Maill;
            yorum.Yorum = yorumlar.Yorum;
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}