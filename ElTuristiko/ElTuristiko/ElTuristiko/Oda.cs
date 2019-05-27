using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    abstract class Oda
    {
        private float fiyat;
        private  List<string> ozellikler;
        private int odaKapasitesi;
        private int odaId;

        public Oda(float fiyat, List<string> ozellikler, int odaKapasitesi)
        {
            this.fiyat = fiyat;
            this.ozellikler = ozellikler;
            this.odaKapasitesi = odaKapasitesi;

        }

        public float Fiyat { get => fiyat; }
        public List<string> Ozellikler { get => ozellikler;  }
        public int OdaKapasitesi { get => odaKapasitesi;  }
        public int OdaId { get => odaId; set => odaId = value; }
    }
}
