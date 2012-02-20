using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap myBitmap = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = myBitmap;

            int height = myBitmap.Height;

            int width = myBitmap.Width;

            int halfwidth = width / 2;
            
            for (int i = 1; i <= halfwidth; i++)
            {
                for (int j = 1; j < height; j++)
                {
                    Color pixelColor1 = myBitmap.GetPixel(i, j);

                    Color pixelColor2 = myBitmap.GetPixel(halfwidth + (halfwidth - i), j);

                    Color pixelTemp = pixelColor2;

                    myBitmap.SetPixel(halfwidth + (halfwidth - i), j, pixelColor1);

                    myBitmap.SetPixel(i, j, pixelTemp);
                }
            }
            /*
            Bitmap bm = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = bm;
            
            for (int i = 0; i < 200; i++)
            {
                bm.SetPixel(i, i, Color.Red);
            }
           */
            pictureBox1.Update();

            MessageBox.Show("Готово!");
        }
    }
}
