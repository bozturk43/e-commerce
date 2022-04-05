using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
        public string Resim { get; set; }
        public bool Durum { get; set; }

        public int KategoriId { get; set; }

    }
}