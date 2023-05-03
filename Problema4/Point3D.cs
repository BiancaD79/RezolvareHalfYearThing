using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    public class Point3D
    {
        public float X, Y, Z;
        public bool visited;
        public static Point3D Empty;
        public Point3D(float x, float y, float z)
        {
            visited = false;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public void Draw(Graphics handler)
        {
            handler.DrawEllipse(Pens.Black, X, Y, 4, 4);
        }
    }
}