using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    public abstract class Otel
    {
        private string otelAdi;
        private string konum;
        private int yildizSayisi;
        private string tur;
        private List<Oda> odalar;
        private List<Rezervasyon> rezervasyonlar;

        protected Otel(string otelAdi, string konum, int yildizSayisi, string tur)
        {
            this.otelAdi = otelAdi;
            this.konum = konum;
            this.yildizSayisi = yildizSayisi;
            this.tur = tur;
            this.odalar = new List<Oda>();
            this.rezervasyonlar = new List<Rezervasyon>();
        }

        public string OtelAdi { get => otelAdi; set => otelAdi = value; }
        public string Konum { get => konum; set => konum = value; }
        public int YildizSayisi { get => yildizSayisi; set => yildizSayisi = value; }
        public string Tur { get => tur; set => tur = value; }
        public List<Oda> Odalar { get => odalar; set => odalar = value; }
        public List<Rezervasyon> Rezervasyonlar { get => rezervasyonlar; set => rezervasyonlar = value; }
        public void OdalaraEkle(Oda oda)
        {
            odalar.Add(oda);
        }

    }
}
