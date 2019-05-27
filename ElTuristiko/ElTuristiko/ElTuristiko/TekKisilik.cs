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

    }
}
