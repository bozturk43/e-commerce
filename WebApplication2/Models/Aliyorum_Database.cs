using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication2.Models
{
    public class Aliyorum_Database:DbContext
    {
        public DbSet<Adresler> adresler { get; set; }
        public DbSet<Bankalar> bankalar { get; set; }
        public DbSet<EkFiyatCarpan> ekfiyatcarpan { get; set; }
        public DbSet<Faturalar> faturalar { get; set; }
        public DbSet<Favoriler> favoriler { get; set; }
        public DbSet<GuvenlikCevaplari> guvenlikcevaplari { get; set; }
        public DbSet<GuvenlikSorulari> guvenliksorulari { get; set; }
        public DbSet<Hizmetlerimiz> hizmetlerimiz { get; set; }
        public DbSet<Iadeler> iadeler { get; set; }
        public DbSet<KampanyaBanner> kampanyabanner { get; set; }
        public DbSet<Kampanyalar> kampanyalar { get; set; }
        public DbSet<Kargolar> kargolar { get; set; }
        public DbSet<Kategoriler> kategoriler { get; set; }
        public DbSet<KullaniciBilgileri> kullanicibilgileri { get; set; }
        public DbSet<Kullanicilar> kullanicilar { get; set; }
        public DbSet<Markalar> markalar { get; set; }
        public DbSet<Mesajlar> mesajlar { get; set; }
        public DbSet<OdemeSecenekleri> odemesecenekleri { get; set; }
        public DbSet<Reklam> reklam { get; set; }
        public DbSet<SayfalarBlok> sayfalarblok { get; set; }
        public DbSet<Siparislerim> siparislerim { get; set; }
        public DbSet<Slider> slider { get; set; }
        public DbSet<Stok> stok { get; set; }
        public DbSet<Taksitler> taksitler { get; set; }
        public DbSet<TaksitTablosu> talsittablosu { get; set; }
        public DbSet<Urunler> urunler { get; set; }
        public DbSet<UrunMaterial> urunmateriyal { get; set; }
        public DbSet<UrunOlcu> urunolcu { get; set; }
        public DbSet<UrunOzellik> urunozellik { get; set; }
        public DbSet<UrunRenk> urunrenk { get; set; }
        public DbSet<UrunResim> urunresim { get; set; }
        public DbSet<UrunSepet> urunsepet { get; set; }
        public DbSet<UrunYorum> urunyorum { get; set; }
        public DbSet<Yetkiler> yetkiler { get; set; }
        public DbSet<Sayfalar> sayfalar { get; set; }
        public DbSet<Iletisim> iletisim { get; set; }



    }
}