using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Yetkiler
    {
        public int Id { get; set; }
        public string Yetki { get; set; }
        public bool Durum { get; set; }

    }
}