using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    class TekKisilik : Oda
    {
        public TekKisilik(float fiyat, List<string> ozellikler, int odaKapasitesi) : base(fiyat, ozellikler, odaKapasitesi)
        {
        }
        private int tip = 3;
        private bool ayriMi = false;
        public int Tip { get => tip; set => tip = value; }
    }
}
