﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    class Yonetici:Kullanici
    {
        private Otel yonetilenOtel;

        public Yonetici(string kullaniciAdi, string sifre, int tcNo, string adSoyad, bool yoneticiMi) : base(kullaniciAdi, sifre, tcNo, adSoyad, yoneticiMi)
        {
        }

        internal Otel YonetilenOtel { get => yonetilenOtel; set => yonetilenOtel = value; }

        public void OdaEkle(Oda oda)
        {

        }
        public void OdaSil(int odaId)
        {

        }

    }
}
