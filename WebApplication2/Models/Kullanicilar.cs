using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Kullanicilar
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sifre { get; set; }
        public bool Durum { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set; }

        


        public int YetkilerId { get; set; }      
    }
}