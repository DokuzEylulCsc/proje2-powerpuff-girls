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

        protected Otel(string otelAdi, string konum, int yildizSayisi, string tur)
        {
            this.otelAdi = otelAdi;
            this.konum = konum;
            this.yildizSayisi = yildizSayisi;
            this.tur = tur;
        }

        public string OtelAdi { get => otelAdi;  }
        public string Konum { get => konum; }
        public int YildizSayisi { get => yildizSayisi;  }
        public string Tur { get => tur;  }
        internal List<Oda> Odalar { get => odalar;  }
        public void OdalaraEkle(Oda oda) { }

    }
}
