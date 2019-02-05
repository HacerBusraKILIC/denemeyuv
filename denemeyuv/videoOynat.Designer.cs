namespace denemeyuv
{
    partial class videoOynat
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
            this.components = new System.ComponentModel.Container();
            this.videoBox = new System.Windows.Forms.PictureBox();
            this.oynat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // videoBox
            // 
            this.videoBox.Location = new System.Drawing.Point(13, 13);
            this.videoBox.Name = "videoBox";
            this.videoBox.Size = new System.Drawing.Size(534, 289);
            this.videoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.videoBox.TabIndex = 0;
            this.videoBox.TabStop = false;
            // 
            // oynat
            // 
            this.oynat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.oynat.Location = new System.Drawing.Point(472, 308);
            this.oynat.Name = "oynat";
            this.oynat.Size = new System.Drawing.Size(75, 23);
            this.oynat.TabIndex = 1;
            this.oynat.Text = "Oynat";
            this.oynat.UseVisualStyleBackColor = true;
            this.oynat.Click += new System.EventHandler(this.oynat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // videoOynat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(561, 334);
            this.Controls.Add(this.oynat);
            this.Controls.Add(this.videoBox);
            this.Name = "videoOynat";
            this.Text = "videoOynat";
            this.Load += new System.EventHandler(this.videoOynat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox videoBox;
        private System.Windows.Forms.Button oynat;
        private System.Windows.Forms.Timer timer1;
    }
}