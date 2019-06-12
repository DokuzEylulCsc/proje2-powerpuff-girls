using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    class OdaFactory 

    {
        public  CiftKisilik CiftKisilikOlustur(float fiyat, List<string> ozellikler, int kapasite)
        {
            return new CiftKisilik(fiyat,ozellikler,kapasite);
        }

        public  DortKisilik DortKisilikOlustur(float fiyat, List<string> ozellikler, int kapasite)
        {
            return new DortKisilik(fiyat,ozellikler,kapasite);
        }

        public TekKisilik TekKisilikOlustur(float fiyat,List<string> ozellikler,int kapasite)
        {
            return new TekKisilik(fiyat,ozellikler,kapasite);       }
    }
}
