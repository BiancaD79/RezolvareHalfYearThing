using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap btm;
        Graphics g;
        private void Form1_Load(object sender, EventArgs e)
        {
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(btm);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < btm.Width; i++)
            {
                for (int j = 0; j < btm.Height; j++)
                {
                    Color Old = btm.GetPixel(i, j);
                    int nr = Old.R;
                    int ng = 50;
                    int nb = 50;

                    if (nr < 128 ) { nr++;}
                    else
                    { nr--; }
                    //if (nb > 255) nb = 255;
                    Color New = Color.FromArgb(nr, ng, nb);
                    btm.SetPixel(i, j, New);
                }
            }
            pictureBox1.Image = btm;
        }
    }
}
