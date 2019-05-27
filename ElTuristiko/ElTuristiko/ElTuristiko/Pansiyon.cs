using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    class Pansiyon : Otel
    {
        public Pansiyon(string otelAdi, string konum, int yildizSayisi, string tur) : base(otelAdi, konum, yildizSayisi, tur)
        {
        }
    }
}
