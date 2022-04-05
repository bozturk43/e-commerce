using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UrunYorum
    {
        public int Id { get; set; }

        public int KullanicilarId { get; set; }

        public string Yorum { get; set; }
        public string Tarih { get; set; }
        public int UrunId { get; set; }
        public double Puan { get; set; }
        public bool Okuma { get; set; }
        public bool Durum { get; set; }
    }
}