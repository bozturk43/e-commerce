using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Iadeler
    {
        public int Id { get; set; }

        public int KullanicilarId { get; set; }

        public int SiparislerId { get; set; }

        public bool IadeDurumu { get; set; }
        public bool Durum { get; set; }

    }
}