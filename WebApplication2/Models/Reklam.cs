using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Reklam
    {
        public int Id { get; set; }
        public string Resim { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Link { get; set; }
    }
}