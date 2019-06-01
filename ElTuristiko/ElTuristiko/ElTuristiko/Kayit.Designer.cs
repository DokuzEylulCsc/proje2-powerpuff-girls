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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.adSoyad.Location = new System.Drawing.Point(57, 108);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(59, 13);
            this.adSoyad.TabIndex = 2;
            this.adSoyad.Text = "Ad - Soyad";
            // 
            // tcNo
            // 
            this.tcNo.AutoSize = true;
            this.tcNo.Location = new System.Drawing.Point(64, 142);
            this.tcNo.Name = "tcNo";
            this.tcNo.Size = new System.Drawing.Size(38, 13);
            this.tcNo.TabIndex = 3;
            this.tcNo.Text = "TC No";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.AutoSize = true;
            this.kullaniciAdi.Location = new System.Drawing.Point(54, 183);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(64, 13);
            this.kullaniciAdi.TabIndex = 4;
            this.kullaniciAdi.Text = "Kullanıcı Adı";
            this.kullaniciAdi.Click += new System.EventHandler(this.label5_Click);
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Location = new System.Drawing.Point(64, 219);
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
            this.kullaniciSecim.Location = new System.Drawing.Point(179, 65);
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(179, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(179, 219);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 20);
            this.textBox4.TabIndex = 11;
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 298);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}