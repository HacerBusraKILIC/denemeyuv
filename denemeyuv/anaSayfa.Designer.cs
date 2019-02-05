namespace denemeyuv
{
    partial class anaSayfa
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
            this.yuvFormat = new System.Windows.Forms.ComboBox();
            this.enYuv = new System.Windows.Forms.TextBox();
            this.boyYuv = new System.Windows.Forms.TextBox();
            this.tamam = new System.Windows.Forms.Button();
            this.videoOynat = new System.Windows.Forms.Button();
            this.Ayarlar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dosyaSec = new System.Windows.Forms.Button();
            this.bmpKaydet = new System.Windows.Forms.Button();
            this.enLabel = new System.Windows.Forms.Label();
            this.boyLabel = new System.Windows.Forms.Label();
            this.formatLabel = new System.Windows.Forms.Label();
            this.Ayarlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // yuvFormat
            // 
            this.yuvFormat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.yuvFormat.FormattingEnabled = true;
            this.yuvFormat.Items.AddRange(new object[] {
            "4:4:4",
            "4:2:2",
            "4:2:0"});
            this.yuvFormat.Location = new System.Drawing.Point(15, 54);
            this.yuvFormat.Name = "yuvFormat";
            this.yuvFormat.Size = new System.Drawing.Size(121, 21);
            this.yuvFormat.TabIndex = 1;
            // 
            // enYuv
            // 
            this.enYuv.Location = new System.Drawing.Point(200, 55);
            this.enYuv.Name = "enYuv";
            this.enYuv.Size = new System.Drawing.Size(100, 20);
            this.enYuv.TabIndex = 2;
            this.enYuv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enYuv_KeyPress);
            // 
            // boyYuv
            // 
            this.boyYuv.Location = new System.Drawing.Point(345, 55);
            this.boyYuv.Name = "boyYuv";
            this.boyYuv.Size = new System.Drawing.Size(100, 20);
            this.boyYuv.TabIndex = 3;
            this.boyYuv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boyYuv_KeyPress);
            // 
            // tamam
            // 
            this.tamam.Location = new System.Drawing.Point(685, 78);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(75, 23);
            this.tamam.TabIndex = 4;
            this.tamam.Text = "TAMAM";
            this.tamam.UseVisualStyleBackColor = true;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // videoOynat
            // 
            this.videoOynat.Location = new System.Drawing.Point(681, 249);
            this.videoOynat.Name = "videoOynat";
            this.videoOynat.Size = new System.Drawing.Size(91, 23);
            this.videoOynat.TabIndex = 5;
            this.videoOynat.Text = "Video Oynat";
            this.videoOynat.UseVisualStyleBackColor = true;
            this.videoOynat.Click += new System.EventHandler(this.videoOynat_Click);
            // 
            // Ayarlar
            // 
            this.Ayarlar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Ayarlar.Controls.Add(this.formatLabel);
            this.Ayarlar.Controls.Add(this.boyLabel);
            this.Ayarlar.Controls.Add(this.enLabel);
            this.Ayarlar.Controls.Add(this.label1);
            this.Ayarlar.Controls.Add(this.yuvFormat);
            this.Ayarlar.Controls.Add(this.enYuv);
            this.Ayarlar.Controls.Add(this.tamam);
            this.Ayarlar.Controls.Add(this.boyYuv);
            this.Ayarlar.Location = new System.Drawing.Point(12, 97);
            this.Ayarlar.Name = "Ayarlar";
            this.Ayarlar.Size = new System.Drawing.Size(776, 116);
            this.Ayarlar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ayarlar";
            // 
            // dosyaSec
            // 
            this.dosyaSec.Location = new System.Drawing.Point(357, 37);
            this.dosyaSec.Name = "dosyaSec";
            this.dosyaSec.Size = new System.Drawing.Size(75, 23);
            this.dosyaSec.TabIndex = 7;
            this.dosyaSec.Text = "Dosya Seç";
            this.dosyaSec.UseVisualStyleBackColor = true;
            this.dosyaSec.Click += new System.EventHandler(this.dosyaSec_Click);
            // 
            // bmpKaydet
            // 
            this.bmpKaydet.Location = new System.Drawing.Point(681, 278);
            this.bmpKaydet.Name = "bmpKaydet";
            this.bmpKaydet.Size = new System.Drawing.Size(91, 23);
            this.bmpKaydet.TabIndex = 8;
            this.bmpKaydet.Text = "Kaydet(.bmp) ";
            this.bmpKaydet.UseVisualStyleBackColor = true;
            this.bmpKaydet.Click += new System.EventHandler(this.bmpKaydet_Click);
            // 
            // enLabel
            // 
            this.enLabel.AutoSize = true;
            this.enLabel.Location = new System.Drawing.Point(197, 39);
            this.enLabel.Name = "enLabel";
            this.enLabel.Size = new System.Drawing.Size(71, 13);
            this.enLabel.TabIndex = 9;
            this.enLabel.Text = "Dosyanın eni:";
            // 
            // boyLabel
            // 
            this.boyLabel.AutoSize = true;
            this.boyLabel.Location = new System.Drawing.Point(345, 39);
            this.boyLabel.Name = "boyLabel";
            this.boyLabel.Size = new System.Drawing.Size(80, 13);
            this.boyLabel.TabIndex = 10;
            this.boyLabel.Text = "Dosyanın boyu:";
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Location = new System.Drawing.Point(15, 39);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(88, 13);
            this.formatLabel.TabIndex = 11;
            this.formatLabel.Text = "Dosyanın formatı:";
            // 
            // anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 311);
            this.Controls.Add(this.bmpKaydet);
            this.Controls.Add(this.dosyaSec);
            this.Controls.Add(this.Ayarlar);
            this.Controls.Add(this.videoOynat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "anaSayfa";
            this.Ayarlar.ResumeLayout(false);
            this.Ayarlar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox yuvFormat;
        private System.Windows.Forms.TextBox enYuv;
        private System.Windows.Forms.TextBox boyYuv;
        private System.Windows.Forms.Button tamam;
        private System.Windows.Forms.Button videoOynat;
        private System.Windows.Forms.Panel Ayarlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dosyaSec;
        private System.Windows.Forms.Button bmpKaydet;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.Label boyLabel;
        private System.Windows.Forms.Label enLabel;
    }
}

