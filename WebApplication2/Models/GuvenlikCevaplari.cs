using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class GuvenlikCevaplari
    {
        public int Id { get; set; }
        public int GSId { get; set; }

        public int KullanicilarId { get; set; }

        public string Cevap { get; set; }
        public bool Durum { get; set; }
    }
}