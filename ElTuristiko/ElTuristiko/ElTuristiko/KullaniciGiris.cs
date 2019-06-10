using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElTuristiko
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        

        private void kaydol_Click(object sender, EventArgs e)
        {
            Kayit kaydol = new Kayit();
            kaydol.Show();
            
        }

        private void giris_Click(object sender, EventArgs e)
        {
            if(kullaniciAd.Text != "" && kullaniciSifre.Text != "")
            {
                foreach(Musteri musteri in Sistem.GetInstance().Musteriler)
                {
                    Console.WriteLine(musteri.KullaniciAdi, musteri.Sifre);

                    if (musteri.KullaniciAdi == kullaniciAd.Text && musteri.Sifre == kullaniciSifre.Text )
                    {
                        MusteriForm form = new MusteriForm();
                        form.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen giriş bilgilerinizi doğru giriniz", "Hata");
                    }
                }

                foreach (Yonetici yonetici in Sistem.GetInstance().Yoneticiler)
                {
                    Console.WriteLine(yonetici.KullaniciAdi, yonetici.Sifre);
                    if(yonetici.KullaniciAdi == kullaniciAd.Text &&    yonetici.Sifre == kullaniciSifre.Text)
                    {
                        YoneticiForm form = new YoneticiForm();
                        form.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen giriş bilgilerinizi doğru giriniz", "Hata");
                    }
                }

                MessageBox.Show("Lütfen giriş bilgilerinizi doğru giriniz", "Hata");

            }
            else
            {
                MessageBox.Show("Lütfen giriş bilgilerinizi doğru giriniz", "Hata");
            }
        }
    }
}
