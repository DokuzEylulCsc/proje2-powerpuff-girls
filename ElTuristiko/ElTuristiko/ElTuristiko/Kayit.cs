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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void kaydol_Click(object sender, EventArgs e)

        {
            KullaniciFactory factory = new KullaniciFactory();
            if (kullaniciSecim.SelectedIndex == 0)
            {
                Musteri m = factory.MusteriOlustur(kullaniciAdTextBox.Text,
                    sifreTextBox.Text, Convert.ToInt32(tcNo.Text), adTextBox.Text, false);
                Sistem.GetInstance().MusteriEkle(m);
                KullaniciOlusturuldu();
            }
            else if (kullaniciSecim.SelectedIndex == 1)
            {
                Yonetici yonetici = factory.YoneticiOlustur(kullaniciAdTextBox.Text,
                    sifreTextBox.Text, Convert.ToInt32(tcTextBox.Text), adTextBox.Text, true);
                Sistem.GetInstance().YoneticiEkle(yonetici);
                KullaniciOlusturuldu();
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileriniz hatalı.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void KullaniciOlusturuldu()
        {
            DialogResult result = MessageBox.Show("kullanıcı başarı ile oluştu", "Mesaj", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
                this.Dispose();
        }

    }
}
