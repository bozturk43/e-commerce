using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Iletisim
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Tel3 { get; set; }
        public string Adres1 { get; set; }
        public string Adres2 { get; set; }
        public string Adres3 { get; set; }
        public string mail1 { get; set; }
        public string mail2 { get; set; }
        public string mail3 { get; set; }
        public string GoogleMaps { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Pinterest { get; set; }
        public string Youtube { get; set; }
        public string Linkeden { get; set; }
        public string Instagram { get; set; }
        public string Whatsapp { get; set; }
        public string CalismaSaatleri { get; set; }
        public bool Durum { get; set; }

    }
}