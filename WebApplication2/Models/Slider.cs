using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set; }
        public string Baslik { get; set; }
        public string Button { get; set; }
        public string link { get; set; }
        public string Konum { get; set; }
        public int Siralama { get; set; }
        public bool Durum { get; set; }
    }
}