﻿using System;
using System.Windows.Forms;

namespace ElTuristiko
{
    public partial class YoneticiForm : Form
    {
        private Yonetici yonetici;

        public YoneticiForm(Yonetici yonetici)
        {
            this.yonetici = yonetici;
            InitializeComponent();
        }

        private void otelEkleBtn_Click(object sender, EventArgs e)
        {
            OtelFactory factory = new OtelFactory();
            if (otelAdTextBox.Text == "" || konumTextBox.Text == "")
            {
                MessageBox.Show("Lütfen otel bilgilerini doğru giriniz");
                return;
            }
            switch (turCB.SelectedIndex)
            {
                case 0://pansiyon
                    yonetici.YonetilenOtel = factory.PansiyonOlustur(otelAdTextBox.Text, konumTextBox.Text,
                        yildizCB.SelectedIndex + 1.ToString());
                    break;
                case 1://butik otel
                    yonetici.YonetilenOtel = factory.ButikOtelOlustur(otelAdTextBox.Text, konumTextBox.Text,
                        yildizCB.SelectedIndex + 1.ToString());
                    break;
                case 2: //tatil köyü
                    yonetici.YonetilenOtel = factory.TatilKoyuOlustur(otelAdTextBox.Text, konumTextBox.Text,
                        yildizCB.SelectedIndex + 1.ToString());
                    break;
                default:
                    break;
            }
            Sistem.GetInstance().DosyayaKaydet();

        }

        private void YoneticiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
