using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Kargolar
    {
        public int Id { get; set; }
        public string FirmaAdi { get; set; }
        public string FirmaAciklamasi { get; set; }
        public bool Durum { get; set; }

    }
}