using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    class CiftKisilik : Oda
    {
        private bool ayriMi;
        private int tip = 2;

        public CiftKisilik(float fiyat, List<string> ozellikler, int odaKapasitesi) : base(fiyat, ozellikler, odaKapasitesi)
        {
        }

        public bool AyriMi { get => ayriMi; set => ayriMi = value; }
        public int Tip { get => tip; set => tip = value; }
    }
}
