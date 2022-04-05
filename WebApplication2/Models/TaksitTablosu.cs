using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class TaksitTablosu
    {
        public int Id { get; set; }
        public int TaksitSayisi { get; set; }
        public double TaksitTutari { get; set; }
        public double ToplamTutar { get; set; }
        public bool Durum { get; set; }

    }
}