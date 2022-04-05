using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using WebApplication2.Models;
using System.Web.Security;//Giriş Kontrolü Kütüphanesi

namespace WebApplication2.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        DataContext db = new DataContext();

        [Authorize]//Giriş Kontrolü parametresi
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Authorize]
        public ActionResult Hakkimizda()
        {
            var hakkimizda = db.sayfalar.Find(1);

            return View(hakkimizda);
        }
        [HttpPost]
        public ActionResult Hakkimizda(string baslik, HttpPostedFileBase resim, HttpPostedFileBase icon, string kisaAciklama, string aciklama, string title, string description, string keywords, string seoUrl)
        {
            var hakkimizda = db.sayfalar.Find(1);
            string resimyolu = "";
            string resimad = "";
            string iconad = "";
            try
            {
                if (resim != null && resim.ContentLength > 0)
                {
                    resimad = Guid.NewGuid().ToString() + "-" + Path.GetFileName(resim.FileName);

                    resimyolu = Path.Combine(Server.MapPath("~/Content/images"), resimad);
                    resim.SaveAs(resimyolu);
                    hakkimizda.Resim = resimad;
                }

            }
            catch { }

            try
            {
                if (icon != null && icon.ContentLength > 0)
                {
                    iconad = Guid.NewGuid().ToString() + "-" + Path.GetFileName(icon.FileName);
                    resimyolu = Path.Combine(Server.MapPath("~/Content/images"), iconad);
                    icon.SaveAs(resimyolu);
                    hakkimizda.Icon = iconad;
                }


            }
            catch { }




            hakkimizda.SayfaBasligi = baslik;


            hakkimizda.KisaAciklama = kisaAciklama;
            hakkimizda.Aciklama = aciklama;
            hakkimizda.Title = title;
            hakkimizda.Description = description;
            hakkimizda.Keyword = keywords;
            hakkimizda.SeoUrl = seoUrl;

            db.SaveChanges();

            return View(hakkimizda);
        }
        [Authorize]
        public ActionResult Slider()
        {
            var slider = db.slider.ToList();
            return View(slider);
        }
        [HttpGet]
        [Authorize]
        public ActionResult Slider_Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Slider_Ekle(HttpPostedFileBase resim, string baslik, string aciklama, string btnyazi, string link, string konum, string siralama, string durum)
        {
            string resimyolu = "";
            string resimad = "";
            try
            {
                if (resim != null && resim.ContentLength > 0)
                {
                    resimad = Guid.NewGuid().ToString() + "-" + Path.GetFileName(resim.FileName);

                    resimyolu = Path.Combine(Server.MapPath("~/Content/images/slider"), resimad);
                    resim.SaveAs(resimyolu);

                }
            }
            catch { }

            Slider sliderekle = new Slider();
            sliderekle.Resim = resimad;
            sliderekle.Baslik = baslik;
            sliderekle.Aciklama = aciklama;
            sliderekle.Button = btnyazi;
            sliderekle.Konum = konum;
            sliderekle.link = link;
            sliderekle.Siralama = Convert.ToInt32(siralama);
            if (durum == "on")
            {
                sliderekle.Durum = true;
            }
            else
            {
                sliderekle.Durum = false;
            }
            db.slider.Add(sliderekle);
            db.SaveChanges();

            Response.Redirect("~/Admin/Slider");
            return View();
        }
        [HttpGet]
        [Authorize]
        public ActionResult Slider_Duzenle(int id)
        {
            var sliderduzenle = db.slider.Where(x => x.Id == id).FirstOrDefault();
            return View(sliderduzenle);
        }
        [HttpPost]
        public ActionResult Slider_Duzenle(HttpPostedFileBase resim, int id, string baslik, string aciklama, string btnyazi, string link, string konum, string siralama, string durum)
        {
            var sliderduzenle = db.slider.Where(x => x.Id == id).FirstOrDefault();

            string resimyolu = "";
            string resimad = "";
            try
            {
                if (resim != null && resim.ContentLength > 0)
                {
                    resimad = Guid.NewGuid().ToString() + "-" + Path.GetFileName(resim.FileName);

                    resimyolu = Path.Combine(Server.MapPath("~/Content/images/slider"), resimad);
                    resim.SaveAs(resimyolu);
                    sliderduzenle.Resim = resimad;
                }
            }
            catch { }

            sliderduzenle.Baslik = baslik;
            sliderduzenle.Aciklama = aciklama;
            sliderduzenle.Button = btnyazi;
            sliderduzenle.link = link;
            sliderduzenle.Konum = konum;
            sliderduzenle.Siralama = Convert.ToInt32(siralama);
            if (durum == "on")
            {
                sliderduzenle.Durum = true;
            }
            else
            {
                sliderduzenle.Durum = false;
            }
            db.SaveChanges();
            return View(sliderduzenle);
        }
        [Authorize]
        public ActionResult Slider_Sil(int id)
        {
            var sliderduzenle = db.slider.Where(x => x.Id == id).FirstOrDefault();
            db.slider.Remove(sliderduzenle);
            db.SaveChanges();
            Response.Redirect("~/Admin/Slider");
            return View();
        }
        [Authorize]
        public ActionResult Slider_Durum_Duzenle(int id)
        {
            var sliderduzenle = db.slider.Where(x => x.Id == id).FirstOrDefault();
            sliderduzenle.Durum = !sliderduzenle.Durum;
            db.SaveChanges();
            Response.Redirect("~/Admin/Slider");
            return View();
        }
        [HttpGet]
        [Authorize]
        public ActionResult Iletisim()
        {
            var iletisim = db.iletisim.Find(1);

            return View(iletisim);
        }
        [HttpPost]
        public ActionResult Iletisim(HttpPostedFileBase resim, string baslik, string aciklama, string tel1, string tel2, string tel3, string mail1, string mail2, string mail3, string adres1, string adres2, string adres3, string maps, string facebook, string instagram, string twitter, string whatsapp, string pinterest, string linkedin, string youtube, string calismabaslma, string calismabitis, string durum)
        {
            var iletisim = db.iletisim.Find(1);
            string resimyolu = "";
            string resimad = "";
            try
            {
                if (resim != null && resim.ContentLength > 0)
                {
                    resimad = Guid.NewGuid().ToString() + "-" + Path.GetFileName(resim.FileName);

                    resimyolu = Path.Combine(Server.MapPath("~/Content/images"), resimad);
                    resim.SaveAs(resimyolu);
                    iletisim.Resim = resimad;
                }
            }
            catch { }
            if (durum == "on")
                iletisim.Durum = true;
            else
                iletisim.Durum = false;

            iletisim.Baslik = baslik;
            iletisim.Aciklama = aciklama;
            iletisim.Tel1 = tel1; iletisim.Tel2 = tel2; iletisim.Tel3 = tel3;
            iletisim.mail1 = mail1; iletisim.mail2 = mail2; iletisim.mail3 = mail3;
            iletisim.Adres1 = adres1; iletisim.Adres2 = adres2; iletisim.Adres3 = adres3;
            iletisim.GoogleMaps = maps;
            iletisim.Facebook = facebook; iletisim.Instagram = instagram; iletisim.Twitter = twitter; iletisim.Whatsapp = whatsapp;
            iletisim.Pinterest = pinterest; iletisim.Linkeden = linkedin; iletisim.Youtube = youtube;

            iletisim.CalismaSaatleri = calismabaslma + "-" + calismabitis;

            db.SaveChanges();
            return View(iletisim);
        }
        [Authorize]
        public ActionResult Iletisim_Kutusu()
        {
            var mesajlar = db.mesajlar.ToList();
            return View(mesajlar);

        }
        [Authorize]
        public ActionResult Mesaj_Detay(int id)
        {
            var mesaj = db.mesajlar.Find(id);
            var kullanici = db.kullanicilar.Find(mesaj.KullanicilarId);
            ViewBag.email = kullanici.Email;
            ViewBag.adsoyad = kullanici.Ad + " " + kullanici.Soyad;
            return View(mesaj);
        }
        [Authorize]
        public ActionResult Mesaj_Sil(int id)
        {
            var mesajsil = db.mesajlar.Where(x => x.Id == id).FirstOrDefault();
            db.mesajlar.Remove(mesajsil);
            db.SaveChanges();
            Response.Redirect("~/Admin/Iletisim_Kutusu");
            return View();
        }
        [Authorize]
        public ActionResult Yetkiler()
        {
            var yetki = db.yetkiler.ToList();

            return View(yetki);
        }
        [HttpGet]
        [Authorize]
        public ActionResult Yetki_Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yetki_Ekle(string yetki, string durum)
        {
            Yetkiler yetkiler = new Yetkiler();
            yetkiler.Yetki = yetki;
            if (durum == "on")
            {
                yetkiler.Durum = true;
            }
            else
            {
                yetkiler.Durum = false;
            }

            db.yetkiler.Add(yetkiler);
            db.SaveChanges();
            Response.Redirect("~/Admin/Yetkiler");
            return View();
        }
        [HttpGet]
        [Authorize]
        public ActionResult Yetki_Duzenle(int id)
        {
            var yetki = db.yetkiler.Find(id);

            return View(yetki);
        }
        [HttpPost]
        public ActionResult Yetki_Duzenle(int id, string durum, string yetki)
        {
            var yetkiler = db.yetkiler.Find(id);

            yetkiler.Yetki = yetki;
            if (durum == "on")
            {
                yetkiler.Durum = true;
            }
            else
            {
                yetkiler.Durum = false;
            }
            db.SaveChanges();

            return View(yetkiler);
        }
        [Authorize]
        public ActionResult Yetki_Sil(int id)
        {
            var yetkiduzenle = db.yetkiler.Where(x => x.Id == id).FirstOrDefault();
            db.yetkiler.Remove(yetkiduzenle);
            db.SaveChanges();
            Response.Redirect("~/Admin/Yetkiler");
            return View();
        }
        [Authorize]
        public ActionResult Yetki_Durum(int id)
        {
            var yetkiduzenle = db.yetkiler.Where(x => x.Id == id).FirstOrDefault();
            yetkiduzenle.Durum = !yetkiduzenle.Durum;
            db.SaveChanges();
            Response.Redirect("~/Admin/Yetkiler");
            return View();
        }
        [Authorize]
        public ActionResult Kullanicilar()
        {
            var kullanicilar = db.kullanicilar.ToList();

            return View(kullanicilar);
        }
        [HttpGet]
        [Authorize]
        public ActionResult Kullanici_Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kullanici_Ekle(HttpPostedFileBase resim, string ad, string soyad, string email, string aciklama, string yetki, string sifre, string durum)
        {
            Kullanicilar kullanici = new Kullanicilar();

            string resimyolu = "";
            string resimad = "";
            try
            {
                if (resim != null && resim.ContentLength > 0)
                {
                    resimad = Guid.NewGuid().ToString() + "-" + Path.GetFileName(resim.FileName);

                    resimyolu = Path.Combine(Server.MapPath("~/Content/images/kullanici"), resimad);
                    resim.SaveAs(resimyolu);
                    kullanici.Resim = resimad;
                }
            }
            catch { }

            kullanici.Ad = ad;
            kullanici.Soyad = soyad;
            kullanici.Email = email;
            kullanici.Sifre = sifre;
            kullanici.Aciklama = aciklama;
            kullanici.YetkilerId = Convert.ToInt32(yetki);
            if (durum == "on")
            {
                kullanici.Durum = true;
            }
            else
            {
                kullanici.Durum = false;
            }
            db.kullanicilar.Add(kullanici);
            db.SaveChanges();

            Response.Redirect("~/Admin/Kullanicilar");
            return View();
        }
        [HttpGet]
        [Authorize]
        public ActionResult Kullanici_Duzenle(int id)
        {
            var kullanici = db.kullanicilar.Find(id);

            return View(kullanici);
        }
        [HttpPost]
        public ActionResult Kullanici_Duzenle(int id,HttpPostedFileBase resim, string ad, string soyad, string email, string aciklama, string yetki, string sifre, string durum)
        {
            var kullanici = db.kullanicilar.Find(id);

            string resimyolu = "";
            string resimad = "";
            try
            {
                if (resim != null && resim.ContentLength > 0)
                {
                    resimad = Guid.NewGuid().ToString() + "-" + Path.GetFileName(resim.FileName);

                    resimyolu = Path.Combine(Server.MapPath("~/Content/images/kullanici"), resimad);
                    resim.SaveAs(resimyolu);
                    kullanici.Resim = resimad;
                }
            }
            catch { }

            kullanici.Ad = ad;
            kullanici.Soyad = soyad;
            kullanici.Email = email;
            kullanici.Sifre = sifre;
            kullanici.Aciklama = aciklama;
            kullanici.YetkilerId = Convert.ToInt32(yetki);
            if (durum == "on")
            {
                kullanici.Durum = true;
            }
            else
            {
                kullanici.Durum = false;
            }
            
            db.SaveChanges();

            
            return View(kullanici);
        }
        [Authorize]
        public ActionResult Kullanici_Sil(int id)
        {
            var kullanici = db.kullanicilar.Where(x => x.Id == id).FirstOrDefault();
            db.kullanicilar.Remove(kullanici);
            db.SaveChanges();
            Response.Redirect("~/Admin/Kullanicilar");
            return View();
        }
        [Authorize]
        public ActionResult Kullanici_Durum_Duzenle(int id)
        {
            var kullanici = db.kullanicilar.Where(x => x.Id == id).FirstOrDefault();
            kullanici.Durum = !kullanici.Durum;
            db.SaveChanges();
            Response.Redirect("~/Admin/Kullanicilar");
            return View();
        }
        [Authorize]
        public ActionResult Kategoriler()
        {
            var kategori = db.kategoriler.ToList();
            return View(kategori);
        }
        [HttpGet]
        [Authorize]
        public ActionResult Kategori_Ekle()
        {
            var kategori = db.kategoriler.Where(x=>x.KategoriId==0).ToList();
            return View(kategori);
        }
        [HttpPost]
        [Authorize]
        public ActionResult Kategori_Ekle(string kategoriadi,string kategoriid, string siralama, string durum)
        {
            Kategoriler kategoriler = new Kategoriler();

            kategoriler.KategoriAdi = kategoriadi;
            kategoriler.KategoriId = Convert.ToInt32(kategoriid);
            kategoriler.Siralama = Convert.ToInt32(siralama);
            if (durum == "on")
            {
                kategoriler.Durum = true;
            }
            else
            {
                kategoriler.Durum = false;
            }

            db.kategoriler.Add(kategoriler);
            db.SaveChanges();
            Response.Redirect("~/Admin/Kategoriler");
            return View(kategoriler);
        }
        [Authorize]
        public ActionResult Urunler()
        {
            return View();
        }
        [Authorize]
        public ActionResult Siparisler()
        {
            return View();
        }
        [Authorize]
        public ActionResult Kargo_Firmalari()
        {
            return View();
        }
        [Authorize]
        public ActionResult Markalar()
        {
            return View();
        }
        [Authorize]
        public ActionResult Drag_Drop()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giris(string email,string sifre)
        {
            var kullanici = db.kullanicilar.Where(x => x.Email == email && x.Sifre == sifre).FirstOrDefault();
            if (kullanici != null)
            {
                Session["KullaniciId"] = kullanici.Id.ToString();
                FormsAuthentication.SetAuthCookie(kullanici.Id.ToString(),false);
                return RedirectToAction("Index", "Admin"); 
            }
            else
            {
                ViewBag.Mesaj = "Giriş Hatalı";
            }
            return View(kullanici);
        }
        public ActionResult Cikis()
        {
            FormsAuthentication.SignOut();
            Response.Redirect("~/Admin/Giris");
            return View();
        }
    }
}