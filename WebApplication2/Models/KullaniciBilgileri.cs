using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class KullaniciBilgileri
    {
        public int Id { get; set; }

        public int KullanicilarId { get; set; }

        public string Tel { get; set; }
        public string TcNo { get; set; }
        public string DogumTarihi { get; set; }
        public string KayitTarihi { get; set; }
        public string KurtarmaMailAdresi { get; set; }
        public string Cinsiyet { get; set; }
        public string MedeniDurum { get; set; }
        public int CocukSayisi { get; set; }

    }
}