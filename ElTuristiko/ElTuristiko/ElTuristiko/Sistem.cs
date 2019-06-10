using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ElTuristiko
{
    public class Sistem
    {
        private static Sistem instance = null;
        private Sistem()
        {
            rezervasyonlar = new List<Rezervasyon>();
            musteriler = new List<Musteri>();
            yoneticiler = new List<Yonetici>();
            oteller = new List<Otel>();

        }
        public static Sistem GetInstance()
        {
            if (instance == null)
            {
                instance = new Sistem();
                instance.DosyadanOku();
            }
            return instance;
        }
        private List<Otel> oteller;
        private List<Musteri> musteriler;
        private List<Yonetici> yoneticiler;
        private List<Rezervasyon> rezervasyonlar;


        public List<Rezervasyon> Rezervasyonlar { get => rezervasyonlar; set => rezervasyonlar = value; }
        public List<Musteri> Musteriler { get => musteriler; set => musteriler = value; }
        public List<Yonetici> Yoneticiler { get => yoneticiler; set => yoneticiler = value; }

        public void OtelEkle(Otel otel)
        {
            oteller.Add(otel);
            DosyayaKaydet();
        }

        public void MusteriEkle(Musteri musteri)
        {
            musteriler.Add(musteri);
            DosyayaKaydet();
        }

        public void YoneticiEkle(Yonetici yonetici)
        {
            yoneticiler.Add(yonetici);
            DosyayaKaydet();
        }

        private void DosyayaKaydet()
        {
            File.WriteAllText(@"./musteriler.json", JsonConvert.SerializeObject(musteriler));
            File.WriteAllText(@"./yoneticiler.json", JsonConvert.SerializeObject(yoneticiler));
            File.WriteAllText(@"./oteller.json", JsonConvert.SerializeObject(oteller));
        }

        private void DosyadanOku()
        {
            musteriler = JsonConvert.DeserializeObject<List<Musteri>>(File.ReadAllText(@"./musteriler.json"));
            yoneticiler = JsonConvert.DeserializeObject<List<Yonetici>>(File.ReadAllText(@"./yoneticiler.json"));
            oteller = JsonConvert.DeserializeObject<List<Otel>>(File.ReadAllText(@"./oteller.json"));
        }
    }
}
