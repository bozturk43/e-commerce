using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UrunOlcu
    {
        public int Id { get; set; }
        public double Uzunluk { get; set; }
        public double Genislik { get; set; }
        public double Yükseklik { get; set; }
        public int Beden { get; set; }
        public double BedenOlcu { get; set; }
        public bool Durum { get; set; }
    }
}