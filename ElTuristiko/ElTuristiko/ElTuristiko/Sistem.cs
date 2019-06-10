using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            rezervasyonlar = new List<Rezervasyon>();
            musteriler = new List<Musteri>();
            yoneticiler = new List<Yonetici>();
            oteller = new List<Otel>();

        }
        public static Sistem Nesne()
        {
            if (nesne == null)
            {
                nesne = new Sistem();
            }
            

            return nesne;
            
        }
        private static  List<Otel> oteller;
        private static List<Musteri> musteriler;
        private static List<Yonetici> yoneticiler;
        private static List<Rezervasyon> rezervasyonlar;

       

        public List<Rezervasyon> Rezervasyonlar { get => rezervasyonlar; set => rezervasyonlar = value; }
        public static List<Musteri> Musteriler { get => musteriler; set => musteriler = value; }
        public static List<Yonetici> Yoneticiler { get => yoneticiler; set => yoneticiler = value; }
        public static List<Rezervasyon> Rezervasyonlar1 { get => rezervasyonlar; set => rezervasyonlar = value; }

        public static void OtelEkle(Otel otel)
        {
            oteller.Add(otel);
            
        }

        public static void MusteriEkle( Musteri musteri)
        {
        
            musteriler.Add(musteri);
            
        }

        public static void YoneticiEkle(Yonetici yonetici)
        {
            yoneticiler.Add(yonetici);
        }

        public static void DosyayaKaydet()
        {

        }

        public static Sistem DosyadanOku()
        {
            return null;
        }
    }
}
