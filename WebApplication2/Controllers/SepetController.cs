using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class SepetController : Controller
    {
        DataContext db = new DataContext();
        // GET: Sepet
        [Authorize]
        public ActionResult Index()
        {
            return View(GetSepet());
        }
        public ActionResult SepeteEkle(int adet,int Id)
        {
            var urunler = db.urunler.FirstOrDefault(x => x.Id == Id);
            if (urunler != null)
            {
                GetSepet().UrunEkle(urunler, adet);
            }
            return RedirectToAction("Index");
        }
        public ActionResult SepetSil(int Id)
        {
            var urunler = db.urunler.FirstOrDefault(x => x.Id == Id);
            if (urunler != null)
            {
                GetSepet().UrunSil(urunler);
            }
            return RedirectToAction("Index");
        }
        public Sepet GetSepet()
        {
           
            Sepet sepet = (Sepet)Session["Sepet"];
            if (sepet == null)
            {
                sepet = new Sepet();
                Session["Sepet"] = sepet;
            }

            return sepet;
        }
    }
}