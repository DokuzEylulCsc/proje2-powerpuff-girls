﻿namespace ElTuristiko
{
    partial class KullaniciGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullaniciAd = new System.Windows.Forms.TextBox();
            this.kullaniciSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.giris = new System.Windows.Forms.Button();
            this.kaydol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciAd
            // 
            this.kullaniciAd.Location = new System.Drawing.Point(135, 144);
            this.kullaniciAd.Name = "kullaniciAd";
            this.kullaniciAd.Size = new System.Drawing.Size(100, 20);
            this.kullaniciAd.TabIndex = 0;
            // 
            // kullaniciSifre
            // 
            this.kullaniciSifre.Location = new System.Drawing.Point(135, 185);
            this.kullaniciSifre.Name = "kullaniciSifre";
            this.kullaniciSifre.Size = new System.Drawing.Size(100, 20);
            this.kullaniciSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Şifre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "KULLANICI GİRİŞ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(105, 296);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(75, 23);
            this.giris.TabIndex = 5;
            this.giris.Text = "GİRİŞ";
            this.giris.UseVisualStyleBackColor = true;
            // 
            // kaydol
            // 
            this.kaydol.Location = new System.Drawing.Point(471, 295);
            this.kaydol.Name = "kaydol";
            this.kaydol.Size = new System.Drawing.Size(75, 23);
            this.kaydol.TabIndex = 6;
            this.kaydol.Text = "KAYIT OL";
            this.kaydol.UseVisualStyleBackColor = true;
            this.kaydol.Click += new System.EventHandler(this.kaydol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 440);
            this.Controls.Add(this.kaydol);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullaniciSifre);
            this.Controls.Add(this.kullaniciAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciAd;
        private System.Windows.Forms.TextBox kullaniciSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Button kaydol;
    }
}
