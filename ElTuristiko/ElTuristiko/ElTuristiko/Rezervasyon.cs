using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{      
    public class Rezervasyon
    {
        private int rezervasyonId;
        private DateTime rezervasyonBaslangic;
        private DateTime rezervasyonBitis;
        private float odenecekUcret;
        private Otel otel;
        private int odaId;

        public Rezervasyon(int rezervasyonId, DateTime rezervasyonBaslangic, DateTime rezervasyonBitis, float odenecekUcret, Otel otel, int odaId )
        {
            this.rezervasyonId = rezervasyonId;
            this.rezervasyonBaslangic = rezervasyonBaslangic;
            this.rezervasyonBitis = rezervasyonBitis;
            this.odenecekUcret = odenecekUcret;
            this.otel = otel;
            this.odaId = odaId;
        }

        public int RezervasyonId { get => rezervasyonId;  }
        public DateTime RezervasyonBaslangic { get => rezervasyonBaslangic;  }
        public DateTime RezervasyonBitis { get => rezervasyonBitis; }
        public float OdenecekUcret { get => odenecekUcret;  }
        public int OdaId { get => odaId;  }
        internal Otel Otel { get => otel;  }
    }
}
