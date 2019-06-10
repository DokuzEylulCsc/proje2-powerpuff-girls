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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void kullaniciSecim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kaydol_Click(object sender, EventArgs e)

        {
            if(kullaniciSecim.SelectedIndex==0)
            {
               Musteri musteri = new Musteri(kullaniciAdTextBox.Text,sifreTextBox.Text,Convert.ToInt32(tcTextBox.Text),adTextBox.Text,false);
               Sistem.MusteriEkle(musteri);
                

            }
            else
            {
                Yonetici yonetici = new Yonetici(kullaniciAdi.Text, sifre.Text, Convert.ToInt32(tcNo.Text), adTextBox.Text,true);
                Sistem.YoneticiEkle(yonetici);
                
            }   
        }

        private void Kayit_Load(object sender, EventArgs e)
        {

        }
    }
}
