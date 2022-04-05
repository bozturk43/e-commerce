using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Faturalar
    {
        public int Id { get; set; }

        public int SiparislerId { get; set; }


        public int AdreslerId { get; set; }

        public bool Durum { get; set; }
    }
}