using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    abstract class FactoryOda
    {
        public abstract  TekKisilik TekKisilikOlustur();
        public abstract CiftKisilik CiftKisilikOlustur();
        public abstract DortKisilik DortKisilikOlustur();
    }

}
