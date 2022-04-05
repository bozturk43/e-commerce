using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.SiteModels
{
    public class HomeModel
    {
        public List<Slider> slider { get; set; }
        public List<Urunler> urunler { get; set; }
        public List<Kampanyalar> kampanyalar { get; set; }
        public List<KampanyaBanner> kampanyaBanner { get; set; }

        public List<KampanyaBanner> kampanyaBannerSira { get; set; }
        public List<Reklam> reklam { get; set; }
        public List<Kategoriler> kategoriler { get; set; }

       /* public IEnumerable<Kampanyalar> kampanyalar { get; set; }

        public ICollection<KampanyaBanner> kampanyaBanner { get; set; }*/
    }
}