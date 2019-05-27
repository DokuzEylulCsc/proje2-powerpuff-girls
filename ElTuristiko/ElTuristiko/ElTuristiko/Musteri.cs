using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    class Musteri:Kullanici
    {
        private List<Rezervasyon> rezervasyonlar;

        public Musteri(string kullaniciAdi, string sifre, int tcNo, string adSoyad, bool yoneticiMi) : base(kullaniciAdi, sifre, tcNo, adSoyad, yoneticiMi)
        {

        }
        public List<Rezervasyon> RezervasyonlaraBak()
        {
            return null;
        }

        public void RezervasyonSil(int rezervaysonId)
        {

        }
    }
}
