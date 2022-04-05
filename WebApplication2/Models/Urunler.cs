using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Urunler
    {
        public int Id { get; set; }

        public int KategorilerId { get; set; }

        public int MarkalarId { get; set; }

        public string UrunAdi { get; set; }
        public string KisaAciklama { get; set; }
        public string Aciklama { get; set; }
        public string Ozellik { get; set; }
        public double Fiyat { get; set; }
        public string Resim { get; set; }
        public bool Durum { get; set; }
        public int Goruntuleme { get; set; }

        public static implicit operator List<object>(Urunler v)
        {
            throw new NotImplementedException();
        }
    }
}