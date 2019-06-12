using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

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
            //singleton çağırıcı
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
            //sisteme otel ekler
            oteller.Add(otel);
            DosyayaKaydet();
        }

        public void MusteriEkle(Musteri musteri)
        {
            //sisteme müşteri ekler
            musteriler.Add(musteri);
            DosyayaKaydet();
        }

        public void YoneticiEkle(Yonetici yonetici)
        {
            //sisteme yönetici ekler
            yoneticiler.Add(yonetici);
            DosyayaKaydet();
        }

        public void DosyayaKaydet()
        {
            //bilgileri json.net kütüphanesi ile dosyalara yazar
            File.WriteAllText(@"./musteriler.json", JsonConvert.SerializeObject(musteriler));
            File.WriteAllText(@"./yoneticiler.json", JsonConvert.SerializeObject(yoneticiler));
            File.WriteAllText(@"./oteller.json", JsonConvert.SerializeObject(oteller));
        }

        public void DosyadanOku()
        {
            //bilgileri json.net kütüphanesi ile dosyalardan okur
            JsonConverter[] converters = { new OtelConverter() };
            musteriler = JsonConvert.DeserializeObject<List<Musteri>>(File.ReadAllText(@"./musteriler.json"));
            yoneticiler = JsonConvert.DeserializeObject<List<Yonetici>>(File.ReadAllText(@"./yoneticiler.json")
                , new JsonSerializerSettings()
                {
                    Converters = converters
                });
            oteller = JsonConvert.DeserializeObject<List<Otel>>(File.ReadAllText(@"./oteller.json"));
        }
    }
}
