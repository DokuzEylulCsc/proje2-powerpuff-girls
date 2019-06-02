using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    public  abstract class Kullanici
    {
        private string kullaniciAdi;
        private string sifre;
        private int tcNo;
        private string adSoyad;
        private bool yoneticiMi;

        protected Kullanici(string kullaniciAdi, string sifre, int tcNo, string adSoyad, bool yoneticiMi)
        {
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
            this.tcNo = tcNo;
            this.adSoyad = adSoyad;
            this.yoneticiMi = yoneticiMi;
        }
        private Kullanici()
        {

        }

        public string KullaniciAdi { get => kullaniciAdi;  }
        public string Sifre { get => sifre;  }
        public int TcNo { get => tcNo;  }
        public string AdSoyad { get => adSoyad;  }
        public bool YoneticiMi { get => yoneticiMi; }

        public void BilgiGuncelle(string kullaniciAdi, string sifre, int tcNo, string adSoyad, bool yoneticiMi)
        {

        }
    }
}
