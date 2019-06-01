using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
     public class Sistem
    {
        private static Sistem nesne = new Sistem();
        private Sistem()
        {
           musteriler.Add

        }
        public static Sistem Nesne()
        {
            if (nesne == null)
            {
                nesne = new Sistem();
            }
            

            return nesne;
            
        }
        private List<Otel> oteller;
        private List<Musteri> musteriler;
        private List<Yonetici> yoneticiler;
        private List<Rezervasyon> rezervasyonlar;

        public List<Rezervasyon> Rezervasyonlar { get => rezervasyonlar; set => rezervasyonlar = value; }


       

        public Otel OtelEkle(Otel otel)
        {
            return null;
        }

        public Musteri MusteriEkle( Musteri musteri)
        {
            return null;
        }

        public Yonetici YoneticiEkle(Yonetici yonetici)
        {
            return null;
        }

        public void DosyayaKaydet()
        {

        }

        public Sistem DosyadanOku()
        {
            return null;
        }
    }
}
