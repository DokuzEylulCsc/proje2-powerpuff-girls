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
            this.label1.Location = new System.Drawing.Point(169, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Kayıt Ol";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kullaniciTur
            // 
            this.kullaniciTur.AutoSize = true;
            this.kullaniciTur.Location = new System.Drawing.Point(72, 84);
            this.kullaniciTur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kullaniciTur.Name = "kullaniciTur";
            this.kullaniciTur.Size = new System.Drawing.Size(94, 17);
            this.kullaniciTur.TabIndex = 1;
            this.kullaniciTur.Text = "Kullanıcı Türü";
            // 
            // adSoyad
            // 
            this.adSoyad.AutoSize = true;
            this.adSoyad.Location = new System.Drawing.Point(76, 133);
            this.adSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(78, 17);
            this.adSoyad.TabIndex = 2;
            this.adSoyad.Text = "Ad - Soyad";
            // 
            // tcNo
            // 
            this.tcNo.AutoSize = true;
            this.tcNo.Location = new System.Drawing.Point(85, 175);
            this.tcNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tcNo.Name = "tcNo";
            this.tcNo.Size = new System.Drawing.Size(48, 17);
            this.tcNo.TabIndex = 3;
            this.tcNo.Text = "TC No";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.AutoSize = true;
            this.kullaniciAdi.Location = new System.Drawing.Point(72, 225);
            this.kullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(84, 17);
            this.kullaniciAdi.TabIndex = 4;
            this.kullaniciAdi.Text = "Kullanıcı Adı";
            this.kullaniciAdi.Click += new System.EventHandler(this.label5_Click);
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Location = new System.Drawing.Point(85, 270);
            this.sifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(37, 17);
            this.sifre.TabIndex = 5;
            this.sifre.Text = "Şifre";
            // 
            // kullaniciSecim
            // 
            this.kullaniciSecim.FormattingEnabled = true;
            this.kullaniciSecim.Items.AddRange(new object[] {
            "Müşteri",
            "Yönetici"});
            this.kullaniciSecim.Location = new System.Drawing.Point(239, 80);
            this.kullaniciSecim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullaniciSecim.Name = "kullaniciSecim";
            this.kullaniciSecim.Size = new System.Drawing.Size(191, 24);
            this.kullaniciSecim.TabIndex = 6;
            this.kullaniciSecim.Text = "Seçiniz";
            this.kullaniciSecim.SelectedIndexChanged += new System.EventHandler(this.kullaniciSecim_SelectedIndexChanged);
            // 
            // kaydol
            // 
            this.kaydol.Location = new System.Drawing.Point(331, 324);
            this.kaydol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kaydol.Name = "kaydol";
            this.kaydol.Size = new System.Drawing.Size(100, 28);
            this.kaydol.TabIndex = 7;
            this.kaydol.Text = "Kayıt Ol";
            this.kaydol.UseVisualStyleBackColor = true;
            this.kaydol.Click += new System.EventHandler(this.kaydol_Click);
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(239, 129);
            this.adTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(191, 22);
            this.adTextBox.TabIndex = 8;
            this.adTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tcTextBox
            // 
            this.tcTextBox.Location = new System.Drawing.Point(239, 175);
            this.tcTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(191, 22);
            this.tcTextBox.TabIndex = 9;
            this.tcTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // kullaniciAdTextBox
            // 
            this.kullaniciAdTextBox.Location = new System.Drawing.Point(239, 225);
            this.kullaniciAdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullaniciAdTextBox.Name = "kullaniciAdTextBox";
            this.kullaniciAdTextBox.Size = new System.Drawing.Size(191, 22);
            this.kullaniciAdTextBox.TabIndex = 10;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(239, 270);
            this.sifreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(191, 22);
            this.sifreTextBox.TabIndex = 11;
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 367);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Kayit";
            this.Text = "Kayit";
            this.Load += new System.EventHandler(this.Kayit_Load);
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