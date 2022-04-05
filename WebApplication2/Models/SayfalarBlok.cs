using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class SayfalarBlok
    {
        public int Id { get; set; }
        public string Blok { get; set; }
        public int Siralama { get; set; }
        public string Konum { get; set; }
        public int Zindex { get; set; }
        public bool Durum { get; set; }
    }
}