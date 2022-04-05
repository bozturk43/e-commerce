using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Siparislerim
    {
        public int Id { get; set; }

        public string KargoNo { get; set; }
        public bool Durum { get; set; }
        public string OngorulenTeslimTarihi { get; set; }
        public string TeslimTarihi { get; set; }
        public bool TeslimDurum { get; set; }
        public double Tutar { get; set; }



        public int KullanicilarId { get; set; }
        

        public int UrunSepetlerId { get; set; }


        public int OdemeSecenekleriId { get; set; }

        public int KargolarId { get; set; }
    }
}