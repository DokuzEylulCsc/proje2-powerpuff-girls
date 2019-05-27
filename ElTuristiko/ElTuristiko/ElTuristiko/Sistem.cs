using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    class Sistem
    {
        private List<Otel> oteller;
        private List<Musteri> musteriler;
        private List<Yonetici> yoneticiler;
        private List<Rezervasyon> rezervasyonlar;

        public List<Rezervasyon> Rezervasyonlar { get => rezervasyonlar; set => rezervasyonlar = value; }

        public static Sistem GetSistem()
        {
            return null;
        }

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
