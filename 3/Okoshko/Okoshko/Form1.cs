using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Okoshko
{
    public partial class Form1 : Form
    {
        int x1, y1, x2, y2;
        Label[] Nomer = new Label[10];
        int i = 0;
        int ilabelX, ilabelY;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Nomer[i] = new Label(); 
            Nomer[i].Location = new System.Drawing.Point((this.Width / 2) - 60, (this.Height / 2) - 40);
            Nomer[i].Size = new System.Drawing.Size(120, 50);
            Nomer[i].Text = textBox1.Text;
            Nomer[i].TextAlign = ContentAlignment.MiddleCenter;
            Nomer[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Nomer[i].MouseDown += new System.Windows.Forms.MouseEventHandler(this.Nomer_MouseDown); 
            Nomer[i].MouseUp += new System.Windows.Forms.MouseEventHandler(this.Nomer_MouseUp); 
            Controls.Add(Nomer[i]);
            i++;

            textBox1.Text = String.Empty;
        }

        private void Nomer_MouseDown(object sender, EventArgs e)
        {
            Label link = (Label)sender;

            ilabelX = link.Location.X;
            ilabelY = link.Location.Y;
            x1 = System.Windows.Forms.Cursor.Position.X;
            y1 = System.Windows.Forms.Cursor.Position.Y;
        }

        private void Nomer_MouseUp(object sender, EventArgs e)
        {
            x2 = System.Windows.Forms.Cursor.Position.X;
            y2 = System.Windows.Forms.Cursor.Position.Y;

            Label link = (Label)sender;

            link.Location = new Point(ilabelX + (x2 - x1), ilabelY + (y2 - y1));
            Controls.Add(link);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < i; j++)
            {
                this.Nomer[j].Click -= new System.EventHandler(this.Nomer_MouseDown);
                Controls.Remove(Nomer[j]);
                Nomer[j].Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < i; j++)
            {
                if (Nomer[j].Text == textBox1.Text)
                {
                    this.Nomer[j].Click -= new System.EventHandler(this.Nomer_MouseDown);
                    Controls.Remove(Nomer[j]);
                    Nomer[j].Dispose();
                }
            }
            textBox1.Text = String.Empty;
        }
        
    }
}
