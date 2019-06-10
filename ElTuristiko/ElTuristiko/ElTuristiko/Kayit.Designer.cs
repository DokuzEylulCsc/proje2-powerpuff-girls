namespace ElTuristiko
{
    partial class Kayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.kullaniciTur = new System.Windows.Forms.Label();
            this.adSoyad = new System.Windows.Forms.Label();
            this.tcNo = new System.Windows.Forms.Label();
            this.kullaniciAdi = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.Label();
            this.kullaniciSecim = new System.Windows.Forms.ComboBox();
            this.kaydol = new System.Windows.Forms.Button();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.tcTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Kayıt Ol";
            // 
            // kullaniciTur
            // 
            this.kullaniciTur.AutoSize = true;
            this.kullaniciTur.Location = new System.Drawing.Point(54, 68);
            this.kullaniciTur.Name = "kullaniciTur";
            this.kullaniciTur.Size = new System.Drawing.Size(71, 13);
            this.kullaniciTur.TabIndex = 1;
            this.kullaniciTur.Text = "Kullanıcı Türü";
            // 
            // adSoyad
            // 
            this.adSoyad.AutoSize = true;
            this.adSoyad.Location = new System.Drawing.Point(54, 105);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(59, 13);
            this.adSoyad.TabIndex = 2;
            this.adSoyad.Text = "Ad - Soyad";
            // 
            // tcNo
            // 
            this.tcNo.AutoSize = true;
            this.tcNo.Location = new System.Drawing.Point(54, 142);
            this.tcNo.Name = "tcNo";
            this.tcNo.Size = new System.Drawing.Size(38, 13);
            this.tcNo.TabIndex = 3;
            this.tcNo.Text = "TC No";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.AutoSize = true;
            this.kullaniciAdi.Location = new System.Drawing.Point(54, 179);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(64, 13);
            this.kullaniciAdi.TabIndex = 4;
            this.kullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Location = new System.Drawing.Point(54, 216);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(28, 13);
            this.sifre.TabIndex = 5;
            this.sifre.Text = "Şifre";
            // 
            // kullaniciSecim
            // 
            this.kullaniciSecim.FormattingEnabled = true;
            this.kullaniciSecim.Items.AddRange(new object[] {
            "Müşteri",
            "Yönetici"});
            this.kullaniciSecim.Location = new System.Drawing.Point(179, 64);
            this.kullaniciSecim.Name = "kullaniciSecim";
            this.kullaniciSecim.Size = new System.Drawing.Size(144, 21);
            this.kullaniciSecim.TabIndex = 6;
            this.kullaniciSecim.Text = "Seçiniz";
            // 
            // kaydol
            // 
            this.kaydol.Location = new System.Drawing.Point(248, 263);
            this.kaydol.Name = "kaydol";
            this.kaydol.Size = new System.Drawing.Size(75, 23);
            this.kaydol.TabIndex = 7;
            this.kaydol.Text = "Kayıt Ol";
            this.kaydol.UseVisualStyleBackColor = true;
            this.kaydol.Click += new System.EventHandler(this.kaydol_Click);
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(179, 101);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(144, 20);
            this.adTextBox.TabIndex = 8;
            // 
            // tcTextBox
            // 
            this.tcTextBox.Location = new System.Drawing.Point(179, 138);
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(144, 20);
            this.tcTextBox.TabIndex = 9;
            // 
            // kullaniciAdTextBox
            // 
            this.kullaniciAdTextBox.Location = new System.Drawing.Point(179, 175);
            this.kullaniciAdTextBox.Name = "kullaniciAdTextBox";
            this.kullaniciAdTextBox.Size = new System.Drawing.Size(144, 20);
            this.kullaniciAdTextBox.TabIndex = 10;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(179, 212);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(144, 20);
            this.sifreTextBox.TabIndex = 11;
            this.sifreTextBox.UseSystemPasswordChar = true;
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 298);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciAdTextBox);
            this.Controls.Add(this.tcTextBox);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.kaydol);
            this.Controls.Add(this.kullaniciSecim);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.tcNo);
            this.Controls.Add(this.adSoyad);
            this.Controls.Add(this.kullaniciTur);
            this.Controls.Add(this.label1);
            this.Name = "Kayit";
            this.Text = "Kayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kullaniciTur;
        private System.Windows.Forms.Label adSoyad;
        private System.Windows.Forms.Label tcNo;
        private System.Windows.Forms.Label kullaniciAdi;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.ComboBox kullaniciSecim;
        private System.Windows.Forms.Button kaydol;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox tcTextBox;
        private System.Windows.Forms.TextBox kullaniciAdTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
    }
}