using System;

namespace ElTuristiko
{
    class OtelFactory 
    {
        
        public ButikOtel ButikOtelOlustur(string otelAdi, string konum, string yildizSayisi)
        {
            return new ButikOtel(otelAdi,konum,Convert.ToInt32(yildizSayisi),"Butik Otel");
        }

        public TatilKoyu TatilKoyuOlustur(string otelAdi, string konum, string yildizSayisi)
        {
            return new TatilKoyu(otelAdi, konum, Convert.ToInt32(yildizSayisi), "Tatil Köyü");

        }

        internal Pansiyon PansiyonOlustur(string otelAdi, string konum, string yildizSayisi)
        {
            return new Pansiyon(otelAdi, konum, Convert.ToInt32(yildizSayisi), "Pansiyon");
       
        }
    }
}
