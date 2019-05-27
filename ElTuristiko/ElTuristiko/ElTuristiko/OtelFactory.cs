using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    class OtelFactory : FactoryOtel
    {
        public override ButikOtel ButikOtelOlustur()
        {
            throw new NotImplementedException();
        }

        public override Pansiyon PansiyonOlustur()
        {
            throw new NotImplementedException();
        }

        public override TatilKoyu TatilKoyuOlustur()
        {
            throw new NotImplementedException();
        }
    }
}
