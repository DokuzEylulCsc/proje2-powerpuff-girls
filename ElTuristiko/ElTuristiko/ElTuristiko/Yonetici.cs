namespace ElTuristiko
{
    public class Yonetici:Kullanici
    {
        private Otel yonetilenOtel = null;

        public Yonetici(string kullaniciAdi, string sifre, int tcNo, string adSoyad,bool yoneticiMi) 
            : base(kullaniciAdi, sifre, tcNo, adSoyad,yoneticiMi)
        {
        }

        public Otel YonetilenOtel { get => yonetilenOtel; set => yonetilenOtel = value; }

        public void OdaEkle(Oda oda)
        {

        }
        public void OdaSil(int odaId)
        {

        }

    }
}
