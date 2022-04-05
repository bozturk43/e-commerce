using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Adresler
    {
        public int Id { get; set; }

        public int KullanicilarId { get; set; }

        public string Ulke { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }
        public string Sokak { get; set; }
        public string Cadde { get; set; }
        public string Blok_No_Daire { get; set; }
        public string AdresBasligi { get; set; }
        public bool Durum { get; set; }
        public bool Secim { get; set; }
        public string PostaKodu { get; set; }




    }


}