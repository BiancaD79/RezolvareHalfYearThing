using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    internal class Solution
    {
        public List<Point3D> points;
        Point3D max1;
        Point3D max2;
        public Solution()
        {
            points = new List<Point3D>();
        }

        public void Add(Point3D p)
        {
            points.Add(p);
            p.visited = true;
        }

        public void Remove(Point3D p)
        {
            points.Remove(p);
            p.visited = true;
        }

        public void Solve()
        {
            float dmax1 = MyMath.Dist(points[0], points[1]);
            max1 = points[0];
            float dmax2 = MyMath.Dist(points[1], points[2]);
            max2 = points[1];
            for (int i = 2; i < points.Count - 1; i++)
            {
                float distCurrent = MyMath.Dist(points[i], points[i + 1]);
                if(dmax1 < distCurrent)
                {
                    dmax2 = dmax1;
                    max2 = max1;
                    dmax1 = distCurrent;
                    max1 = points[i];
                }
                else
                    if(dmax2 < distCurrent)
                {
                    dmax2 = distCurrent;
                    max2 = points[i];
                }
            }
        }

        public void Draw(Graphics handler)
        {
            Solve();
            for (int i = 0; i < points.Count - 1; i++)
            {
                if(points[i] != max1 && points[i] != max2)
                    handler.DrawLine(Pens.Blue, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }
        }
    }
}
