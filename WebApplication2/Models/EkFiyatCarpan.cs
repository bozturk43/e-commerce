using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class EkFiyatCarpan
    {
        public int Id { get; set; }
        public string FiyatAdi { get; set; }
        public double Tutar { get; set; }
        public double Oran { get; set; }
        public bool Durum { get; set; }
        
    }
}