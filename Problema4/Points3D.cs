using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    internal class Points3D
    {
        Random rnd = new Random();
        public Point3D[] points;

        public Points3D(int n)
        {
            points = new Point3D[n];
        }
        public Points3D(string fileName)
        {
            TextReader str = new StreamReader(fileName);
            List<string> p = new List<string>();
            string buffer;
            while ((buffer = str.ReadLine()) != null)
            {
                p.Add(buffer);
            }

            points = new Point3D[p.Count];
            for (int i = 0; i < points.Length; i++)
            {
                string[] local = p[i].Split(' ');
                float X = float.Parse(local[0]);
                float Y = float.Parse(local[1]);
                float Z = float.Parse(local[2]);
                points[i] = new Point3D(X,Y,Z); 
            }
        }
        public void Init(int maxX, int maxY, int maxZ)
        {
            for (int i = 0; i < points.Length; i++)
                points[i] = new Point3D(rnd.Next(maxX), rnd.Next(maxY), rnd.Next(maxZ));
        }
        public void Draw(Graphics handler)
        {
            foreach(Point3D point in points)
                point.Draw(handler);
        }
    }
}
