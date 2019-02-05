using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeyuv
{
    public partial class videoOynat : Form
    {
        static int i = 0;   //videoyu tekrar oynatmak için frame sayı kontrolü

        public videoOynat()
        {
            InitializeComponent();
        }

        private void videoOynat_Load(object sender, EventArgs e)
        {
            videoBox.Width = anaSayfa.width;
            videoBox.Height = anaSayfa.height;
            this.Width = anaSayfa.width;
            this.Height = anaSayfa.height;
           
            videoBox.Image = anaSayfa.frameList[0];
            //videoBox.SizeMode = PictureBoxSizeMode.AutoSize;            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("i" +i);
            videoBox.Image = anaSayfa.frameList[i];
            
            if (i == (anaSayfa.frame_No-1))
            {
                timer1.Stop();
                //videoBox.Image = anaSayfa.frameList[0];
            }
            i++;
        }

        private void oynat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            i = 0;
        }
    }
}
