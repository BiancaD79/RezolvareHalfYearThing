using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    internal class MyGraphics
    {
        PictureBox display;
        Bitmap bmp;
        public Graphics grp;
        public int resx;
        public int resy;
        Color bkColor = Color.LightGray;


        public void InitGraph(PictureBox display)
        {
            this.display = display;
            this.bmp = new Bitmap(display.Width, display.Height);
            resx = display.Width;
            resy = display.Height;
            grp = Graphics.FromImage(bmp);
            ClearGraph();
            RefreshGraph();
        }

        public void ClearGraph()
        {
            grp.Clear(bkColor);
        }

        public void RefreshGraph()
        {
            this.display.Image = bmp;
        }
    }
}
