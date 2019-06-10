using System;
using System.Windows.Forms;

namespace ElTuristiko
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
            Sistem.GetInstance();

        }

        private void kaydol_Click(object sender, EventArgs e)
        {
            Kayit kaydol = new Kayit();
            kaydol.Show();

        }

        private void giris_Click(object sender, EventArgs e)
        {
            if (kullaniciAd.Text != "" && kullaniciSifre.Text != "")
            {
                foreach (Musteri musteri in Sistem.GetInstance().Musteriler)
                {
                    if (musteri.KullaniciAdi == kullaniciAd.Text && musteri.Sifre == kullaniciSifre.Text)
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
                    if (yonetici.KullaniciAdi == kullaniciAd.Text && yonetici.Sifre == kullaniciSifre.Text)
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

        private void KullaniciGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
