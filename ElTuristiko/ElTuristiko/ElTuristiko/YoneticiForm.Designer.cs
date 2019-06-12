namespace ElTuristiko
{
    partial class YoneticiForm
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
            this.otelEkleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.otelAdTextBox = new System.Windows.Forms.TextBox();
            this.konumTextBox = new System.Windows.Forms.TextBox();
            this.yildizCB = new System.Windows.Forms.ComboBox();
            this.turCB = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // otelEkleBtn
            // 
            this.otelEkleBtn.Location = new System.Drawing.Point(503, 31);
            this.otelEkleBtn.Name = "otelEkleBtn";
            this.otelEkleBtn.Size = new System.Drawing.Size(75, 23);
            this.otelEkleBtn.TabIndex = 0;
            this.otelEkleBtn.Text = "Otel Ekle";
            this.otelEkleBtn.UseVisualStyleBackColor = true;
            this.otelEkleBtn.Click += new System.EventHandler(this.otelEkleBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otel Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yıldız Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tür";
            // 
            // otelAdTextBox
            // 
            this.otelAdTextBox.Location = new System.Drawing.Point(12, 31);
            this.otelAdTextBox.Name = "otelAdTextBox";
            this.otelAdTextBox.Size = new System.Drawing.Size(100, 20);
            this.otelAdTextBox.TabIndex = 6;
            // 
            // konumTextBox
            // 
            this.konumTextBox.Location = new System.Drawing.Point(118, 31);
            this.konumTextBox.Name = "konumTextBox";
            this.konumTextBox.Size = new System.Drawing.Size(100, 20);
            this.konumTextBox.TabIndex = 7;
            // 
            // yildizCB
            // 
            this.yildizCB.FormattingEnabled = true;
            this.yildizCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.yildizCB.Location = new System.Drawing.Point(224, 31);
            this.yildizCB.Name = "yildizCB";
            this.yildizCB.Size = new System.Drawing.Size(121, 21);
            this.yildizCB.TabIndex = 10;
            // 
            // turCB
            // 
            this.turCB.FormattingEnabled = true;
            this.turCB.Items.AddRange(new object[] {
            "Pansiyon",
            "Butik Otel",
            "Tatil Köyü"});
            this.turCB.Location = new System.Drawing.Point(351, 31);
            this.turCB.Name = "turCB";
            this.turCB.Size = new System.Drawing.Size(121, 21);
            this.turCB.TabIndex = 11;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 64);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // YoneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.turCB);
            this.Controls.Add(this.yildizCB);
            this.Controls.Add(this.konumTextBox);
            this.Controls.Add(this.otelAdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otelEkleBtn);
            this.Name = "YoneticiForm";
            this.Text = "Anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YoneticiForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button otelEkleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox otelAdTextBox;
        private System.Windows.Forms.TextBox konumTextBox;
        private System.Windows.Forms.ComboBox yildizCB;
        private System.Windows.Forms.ComboBox turCB;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}