using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Favoriler
    {
        public int Id { get; set; }

        public int KullanicilarId { get; set; }

        public int UrunlerId { get; set; }

        public string Tarih { get; set; }
        public bool Durum { get; set; }
    }
}