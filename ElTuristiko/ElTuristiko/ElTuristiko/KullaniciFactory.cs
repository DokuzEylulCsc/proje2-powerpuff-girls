using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    class KullaniciFactory 
    {
        public Musteri MusteriOlustur(string kullaniciAd,string sifre,int tcNo,string adSoyad,bool yoneticiMi)
        {
            return new Musteri(kullaniciAd,sifre,tcNo,adSoyad,yoneticiMi);
        }

        public  Yonetici YoneticiOlustur(string kullaniciAd, string sifre, int tcNo, string adSoyad, bool yoneticiMi)
        {
            return new Yonetici(kullaniciAd,sifre,tcNo,adSoyad,yoneticiMi);
        }
    }
}
