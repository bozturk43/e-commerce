using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.SiteModels
{
    public class UrunKategoriModel
    {
        public List<Kategoriler> kategoriler { get; set; }
        public List<Urunler> urunler { get; set; }
    }
}