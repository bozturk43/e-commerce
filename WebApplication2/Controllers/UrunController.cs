using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.SiteModels;

namespace WebApplication2.Controllers
{
    public class UrunController : Controller
    {
        DataContext db = new DataContext();
        // GET: Urun
        public ActionResult Index()
        {
            UrunKategoriModel model = new UrunKategoriModel();

            var urun = db.urunler.Where(x => x.Durum == true).ToList();
            model.urunler = urun;

            var kategori = db.kategoriler.Where(x => x.Durum == true).ToList();
            model.kategoriler = kategori;


            return View(model);
        }
        public ActionResult Detay(int id)
        {
            var urun = db.urunler.Find(id);
            return View(urun);
        }
    }
}