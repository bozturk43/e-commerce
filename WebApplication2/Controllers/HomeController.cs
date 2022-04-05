using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using System.Data.Entity;
using WebApplication2.SiteModels;

namespace WebApplication2.Controllers
{
   
    public class HomeController : Controller
    {
        // GET: Home
        DataContext db = new DataContext();
        public ActionResult Index()
        {
            HomeModel homeModel = new HomeModel();


            var urun = (IEnumerable<Urunler>)(from u in db.urunler select u).Take(5);
            homeModel.urunler = urun.ToList();

            var SS = (IEnumerable<Slider>)(from s in db.slider orderby s.Siralama ascending select s).Take(1);

            homeModel.slider = SS.ToList();

            //db.slider.Where(x=>x.Durum==true).ToList();
            
            
            homeModel.reklam = db.reklam.ToList();
            homeModel.kategoriler = db.kategoriler.Where(x => x.Durum == true).ToList();

            var kampanyabannessira = (IEnumerable<KampanyaBanner>)db.kampanyabanner.Where(x => x.Position == "0").ToList();
            homeModel.kampanyaBannerSira=kampanyabannessira.ToList();

            var kampanyalar = db.kampanyabanner.Where(x => x.Id > 1).ToList();
            homeModel.kampanyaBanner = kampanyalar.ToList();
            //var nihalslider = db.slider.Where(n => n.Baslik.Substring(0, 3) == "nih").ToList();
            return View(homeModel);
        }
    }
}