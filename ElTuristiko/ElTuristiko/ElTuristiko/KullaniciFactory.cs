using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    class KullaniciFactory : FactoryKullanici
    {
        public override Musteri MusteriOlustur()
        {
            throw new NotImplementedException();
        }

        public override Yonetici YoneticiOlustur()
        {
            throw new NotImplementedException();
        }
    }
}
