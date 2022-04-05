using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Kampanyalar
    {
        public int Id { get; set; }

        public int KategorilerId { get; set; }

        public string KampanyaAdi { get; set; }
        public string BaslangicTarihi { get; set; }
        public string BitisTarihi { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public string Link { get; set; }
        public double Oran { get; set; }
        public double Tutar { get; set; }
        public bool Durum { get; set; }

    }
}