using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Solution solution;
        Points3D points;
        MyGraphics g;
        private void Form1_Load(object sender, EventArgs e)
        {
            g = new MyGraphics();
            g.InitGraph(pictureBox1);
            //points = new Points3D(@"..\..\data.txt");
            points = new Points3D(10);
            points.Init(pictureBox1.Width, pictureBox1.Height, 100);
            points.Draw(g.grp);
            solution = new Solution();
            Point3D current = points.points[0];
            solution.Add(current);
            for (int i = 0; i < points.points.Length - 1; i++)
            {
                Point3D near = MyMath.FindNearest(points.points, points.points[0]);
                solution.Add(near);
                near = current;
            }
            solution.Draw(g.grp);
            g.RefreshGraph();
        }
    }
}
