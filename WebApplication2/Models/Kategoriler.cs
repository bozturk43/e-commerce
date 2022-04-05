using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Kategoriler
    {
        public int Id { get; set; }
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public int Siralama { get; set; }
        public bool Durum { get; set; }
        public string Link { get; set; }
        public int Goruntuleme { get; set; }
        public string KategoriIcon { get; set; }

    }
}