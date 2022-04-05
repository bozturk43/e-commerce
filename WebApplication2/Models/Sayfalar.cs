using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Sayfalar
    {
        public int Id { get; set; }
        public string SayfaBasligi { get; set; }
        public string KisaAciklama { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public bool Durum { get; set; }
        public int Siralama { get; set; }
        public int Okuma { get; set; }
        public string SeoUrl { get; set; }

    }
}