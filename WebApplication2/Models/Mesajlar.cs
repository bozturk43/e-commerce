using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Mesajlar
    {
        public int Id { get; set; }

        public int KullanicilarId { get; set; }

        public string Konu { get; set; }
        public string Mesaj { get; set; }
        public bool Okuma { get; set; }
        public bool Durum { get; set; }
    }
}