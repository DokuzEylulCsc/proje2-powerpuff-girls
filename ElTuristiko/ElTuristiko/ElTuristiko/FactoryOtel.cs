using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    abstract class FactoryOtel
    {
        public abstract ButikOtel ButikOtelOlustur();
        public abstract Pansiyon PansiyonOlustur();
        public abstract TatilKoyu TatilKoyuOlustur();


    }
}
