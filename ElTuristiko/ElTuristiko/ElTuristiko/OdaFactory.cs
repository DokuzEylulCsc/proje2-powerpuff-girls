using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    class OdaFactory : FactoryOda

    {
        public override CiftKisilik CiftKisilikOlustur()
        {
            throw new NotImplementedException();
        }

        public override DortKisilik DortKisilikOlustur()
        {
            throw new NotImplementedException();
        }

        public override TekKisilik TekKisilikOlustur()
        {
            throw new NotImplementedException();
        }
    }
}
