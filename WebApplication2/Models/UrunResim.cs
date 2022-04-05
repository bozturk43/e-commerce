using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UrunResim
    {
        public int Id { get; set; }

        public int UrunlerId { get; set; }

        public string Resim { get; set; }
        public int Siralama { get; set; }
        public bool Durum { get; set; }
    }
}