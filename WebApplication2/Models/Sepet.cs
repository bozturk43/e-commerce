using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApplication2.Models
{
    
    public class Sepet
    { 
        private List<SepetUrunler> _liste = new List<SepetUrunler>();

        public List<SepetUrunler> SepetUrunleri
        {
            get { return _liste; }
        }

        public void UrunEkle(Urunler urun,int adet)
        {
            var satir = _liste.FirstOrDefault(x => x.Urunlers.Id == urun.Id);
            if (satir == null)
            {
                
                _liste.Add(new SepetUrunler() { Urunlers = urun, Adet = adet });
            }
            else
            {
                satir.Adet += adet;
            }
        }
        public void UrunSil(Urunler urun)
        {
            _liste.RemoveAll(x => x.Urunlers.Id == urun.Id);
        }
        public void SepetSil()
        {
            _liste.Clear();
        }

        public double ToplamTutar()
        {
            var tutar = _liste.Sum(x => x.Urunlers.Fiyat * x.Adet);

            return tutar;
        }


    }
    public class SepetUrunler
    {
        public Urunler Urunlers { get; set; }
        public int Adet { get; set; }
    }
}