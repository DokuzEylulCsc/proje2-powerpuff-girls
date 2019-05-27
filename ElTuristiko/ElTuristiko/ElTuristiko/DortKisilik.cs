using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    class DortKisilik : Oda
    {
        private List<bool> ayriMi;
        public DortKisilik(float fiyat, List<string> ozellikler, int odaKapasitesi) : base(fiyat, ozellikler, odaKapasitesi)
        {
        }

        public List<bool> AyriMi { get => ayriMi; set => ayriMi = value; }
    }
}
