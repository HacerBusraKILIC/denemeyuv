using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeyuv
{
    public partial class anaSayfa : Form
    {
        static int sayac = 0;
        public static List<Bitmap> frameList = new List<Bitmap>();
        public static int frame_No = 0;
        static string DosyaYolu = "";
        public static int width = 0;
        public static int height = 0;

        Encoding enc = new UTF8Encoding(true, true);

        public anaSayfa()
        {
            InitializeComponent();
            yuvFormat.SelectedIndex = 0;
            yuvFormat.SelectedIndex = 0;
            yuvFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            enYuv.Text = "0";
            boyYuv.Text = "0";
            videoOynat.Visible = false;
            bmpKaydet.Visible = false;
            //dosyaOku("akiyo_qcif.yuv", 176, 144, "4:2:0");
        }

        private void dosyaOku(String yol, int Width, int Height, string Format)
        {
            FileStream infile = File.Open(yol, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryReader br = new BinaryReader(infile, Encoding.ASCII);

            width = Width;    
            height = Height;     //Console.WriteLine("---en: " + width + ", boy: "  +height + ", format: " + Format);
            int imgSize = width * height;
            int frameSize = 0;  //len_y+len_u+len_v
            if (Format.Equals("4:4:4"))
            {
                frameSize = imgSize * 3;
            }
            else if (Format.Equals("4:2:2"))
            {
                frameSize = imgSize * 2;
            }
            else
            {
                frameSize = imgSize + (imgSize >> 1);
            }
                
            frame_No = (int)infile.Length / frameSize;   Console.WriteLine("frame_No " + frame_No + ", frameSize " + frameSize + ", infileLenght " + infile.Length);
            byte[] yuv = new byte[frameSize];   
            byte[] rgb = new byte[3 * imgSize];

            /*byte[] imageData = File.ReadAllBytes(yol);

            var bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0,
                                                                    bmp.Width,
                                                                    bmp.Height),
                                                                    ImageLockMode.WriteOnly,
                                                                    bmp.PixelFormat);
            Marshal.Copy(imageData, 0, bmpData.Scan0, frameSize);
            bmp.UnlockBits(bmpData);*/

            int frameNo = 0;

            while(br.PeekChar() != -1)
            {
                br.Read(yuv, 0, frameSize); //Byte sayısı kadar okuma yapılır
                Bitmap bm = ConvertYUV(yuv, rgb, width, height);

                frameList.Add(bm);
                    
                frameNo++; Console.WriteLine("frameNo: " + frameNo);
            }
    }

        static Bitmap ConvertYUV(byte[] yuvFrame, byte[] rgbFrame, int width, int height)
        {
            int gIndex = width * height;
            int bIndex = gIndex * 2;

            int temp = 0;
            Bitmap bm = new Bitmap(width, height);
            //List<Bitmap> bmList = new List<Bitmap>();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    sayac++;
                    // R
                    temp = (int)(yuvFrame[y * width + x]);
                    rgbFrame[y * width + x] = (byte)(temp < 0 ? 0 : (temp > 255 ? 255 : temp));
                    // G
                    temp = (int)(yuvFrame[y * width + x]);
                    rgbFrame[gIndex + y * width + x] = (byte)(temp < 0 ? 0 : (temp > 255 ? 255 : temp));
                    // B
                    temp = (int)(yuvFrame[y * width + x]);
                    rgbFrame[bIndex + y * width + x] = (byte)(temp < 0 ? 0 : (temp > 255 ? 255 : temp));
                    Color c = Color.FromArgb(rgbFrame[y * width + x], rgbFrame[gIndex + y * width + x], rgbFrame[bIndex + y * width + x]);
                    bm.SetPixel(x, y, c);  //Console.WriteLine("sayac" + sayac); //Console.WriteLine("x: " + x + ", y: " + y + ", c: " + c + ", temp: " + temp);
                }
            }

            return bm;
        }

        private void tamam_Click(object sender, EventArgs e)
        {
            if (DosyaYolu.Equals("") == false) {
                videoOynat.Visible = true;
                bmpKaydet.Visible = true;

                int width = Convert.ToInt32(enYuv.Text);
                int height = Convert.ToInt32(boyYuv.Text);

                string format = yuvFormat.Text;     //Console.WriteLine("en: " + width + ", boy: " + height + ", format: " + format);

                if (format.Equals("4:4:4"))
                {
                    dosyaOku(DosyaYolu, width, height, format);
                }
                else if (format.Equals("4:2:2"))
                {
                    dosyaOku(DosyaYolu, width, height, format);
                    //dosyaOku("stefan_cif.yuv", width, height, format);
                }
                else
                {
                    //dosyaOku("bridge-far_qcif.yuv", width, height, format); 
                    //dosyaOku("tulips_yuv420_inter_planar_qcif.yuv", width, height, format);
                    //dosyaOku("sintel_480x272_yuv420p.yuv", width, height, format); 
                    dosyaOku(DosyaYolu, width, height, format);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir dosya seçiniz!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void videoOynat_Click(object sender, EventArgs e)
        {
            videoOynat videoOynat = new videoOynat();
            videoOynat.Show();          
        }

        private void dosyaSec_Click(object sender, EventArgs e)
        {
            if (frameList != null)
                frameList.Clear();
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "D:\\VS Project\\denemeyuv\\denemeyuv\\bin\\Debug";
            file.Filter = "Yuv Dosyası |*.yuv";
            file.Title = "Yuv Dosyası Seçiniz..";
            if (file.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu = file.FileName;
            }
            //Console.WriteLine(" DosyaYolu = " + file.FileName + "  DosyaAdi = " + file.SafeFileName);
        }

        private void bmpKaydet_Click(object sender, EventArgs e)
        {
            int frame_No = frameList.Count;      //Console.WriteLine(frame_No);
            for (int i = 0; i < frame_No; i++)
            {
                frameList[i].Save("D:\\VS Project\\denemeyuv\\denemeyuv\\bin\\Debug\\frame\\frame_" + i + ".bmp");
            }
        }

        // text box alanlarına metin girişinin engellenmesi
        private void enYuv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void boyYuv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}




/*public Bitmap Bitmap { get; private set; }
public Int32[] Bits { get; private set; }
public bool Disposed { get; private set; }
public int Height { get; private set; }
public int Width { get; private set; }

protected GCHandle BitsHandle { get; private set; }

private void oku(String yol)
{
    try
    {

        using (FileStream fsSource = new FileStream(yol,
            FileMode.Open, FileAccess.Read))
        {

            // Read the source file into a byte array.
            byte[] bytes = new byte[fsSource.Length];
            int numBytesToRead = (int)fsSource.Length;
            int numBytesRead = 0;
            while (numBytesToRead > 0)
            {
                // Read may return anything from 0 to numBytesToRead.
                int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                // Break when the end of the file is reached.
                if (n == 0)
                    break;

                numBytesRead += n;
                numBytesToRead -= n;
            }
            numBytesToRead = bytes.Length;

            // Write the byte array to the other FileStream.


                Width = 176;
                Height = 144;
                Bits = new Int32[176 * 144];
                BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
                Bitmap = new Bitmap(176, 144, 176 * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
            byte[] imageData = File.ReadAllBytes(yol);
            BitmapData bmpData = Bitmap.LockBits(new Rectangle(0, 0,
                                                            Bitmap.Width,
                                                            Bitmap.Height),
                                                            ImageLockMode.WriteOnly,
                                                            Bitmap.PixelFormat);
                Marshal.Copy(imageData, 0, bmpData.Scan0, 176*144);
            Bitmap.UnlockBits(bmpData);
                yuvImage.Image = Bitmap;

        }
    }
    catch (FileNotFoundException ioEx)
    {
        Console.WriteLine(ioEx.Message);
    }
}*/
