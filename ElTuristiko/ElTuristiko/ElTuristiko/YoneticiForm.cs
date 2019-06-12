using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ElTuristiko
{
    public partial class YoneticiForm : Form
    {
        private Yonetici yonetici;
        private DateTime baslangic;
        private DateTime bitis;
        DataTable dt = new DataTable();


        public YoneticiForm(Yonetici yonetici)
        {
            this.yonetici = yonetici;
            InitializeComponent();
            if (yonetici.YonetilenOtel != null)
            {
                otelEkleBtn.Enabled = false;
                otelAdTextBox.Enabled = false;
                konumTextBox.Enabled = false;
                yildizCB.Enabled = false;
                turCB.Enabled = false;
                foreach (Control c in this.Controls)
                {
                    if (c is Label) c.Enabled = false;
                }
            }
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
                        yildizCB.SelectedValue.ToString());
                    break;
                case 1://butik otel
                    yonetici.YonetilenOtel = factory.ButikOtelOlustur(otelAdTextBox.Text, konumTextBox.Text,
                        (yildizCB.SelectedIndex+1).ToString());
                    break;
                case 2: //tatil köyü
                    yonetici.YonetilenOtel = factory.TatilKoyuOlustur(otelAdTextBox.Text, konumTextBox.Text,
                        yildizCB.SelectedValue.ToString());
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

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            baslangic = monthCalendar1.SelectionStart;
            bitis = monthCalendar1.SelectionEnd;
            foreach (Rezervasyon r in yonetici.YonetilenOtel.Rezervasyonlar)
            {
                if (r.RezervasyonBaslangic >= baslangic && r.RezervasyonBitis <= bitis)
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow[0] = r.RezervasyonId;
                    dataRow[1] = r.RezervasyonBaslangic.ToLongTimeString();
                    dataRow[2] = r.RezervasyonBitis.ToLongTimeString();
                    dataRow[3] = r.OdenecekUcret;
                    dataRow[4] = r.OdaId;
                    dt.Rows.Add(dataRow);
                }
            }
        }

        private void YoneticiForm_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Başlangıç");
            dt.Columns.Add("Bitiş");
            dt.Columns.Add("Ücret");
            dt.Columns.Add("Oda Id");
            dataGridView1.DataSource = dt;

        }

        private void odaEkleBtn_Click(object sender, EventArgs e)
        {
            foreach (Oda oda in yonetici.YonetilenOtel.Odalar)
            {
                if (oda.OdaId.ToString() == odaIDtxtbox.Text)
                {
                    MessageBox.Show("Girdiğiniz ID ile oda vardır.");
                    return;
                }
            }
            OdaFactory factory = new OdaFactory();
            List<string> ozellikler = new List<string>(ozelliklerRichTextBox.Lines);
            switch (kapasiteComboBox.SelectedIndex)
            {
                case 0:
                    TekKisilik tek = factory.TekKisilikOlustur(float.Parse(fiyatTxtbox.Text), ozellikler, 1);
                    yonetici.YonetilenOtel.OdalaraEkle(tek);
                    break;
                case 1:
                    CiftKisilik ciftAyri = factory.CiftKisilikOlustur(float.Parse(fiyatTxtbox.Text), ozellikler, 2);
                    ciftAyri.AyriMi = true;
                    yonetici.YonetilenOtel.OdalaraEkle(ciftAyri);
                    break;
                case 2:
                    CiftKisilik ciftKing = factory.CiftKisilikOlustur(float.Parse(fiyatTxtbox.Text), ozellikler, 2);
                    ciftKing.AyriMi = true;
                    yonetici.YonetilenOtel.OdalaraEkle(ciftKing);
                    break;
                case 3:
                    DortKisilik dortAyri = factory.DortKisilikOlustur(float.Parse(fiyatTxtbox.Text), ozellikler, 4);
                    dortAyri.AyriMi = true;
                    yonetici.YonetilenOtel.OdalaraEkle(dortAyri);
                    break;
                case 4:
                    DortKisilik dortKing = factory.DortKisilikOlustur(float.Parse(fiyatTxtbox.Text), ozellikler, 4);
                    dortKing.AyriMi = false;
                    yonetici.YonetilenOtel.OdalaraEkle(dortKing);
                    break;
                default:
                    break;
            }
            Sistem.GetInstance().OtelEkle(yonetici.YonetilenOtel);
        }
    }
}
