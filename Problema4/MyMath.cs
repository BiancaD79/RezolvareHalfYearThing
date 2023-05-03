using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    public static class MyMath
    {
        public static float Dist(Point3D A, Point3D B)
        {
            return (float)Math.Sqrt((A.X - B.X)* (A.X - B.X) + (A.Y - B.Y)* (A.Y - B.Y) + (A.Z - B.Z)* (A.Z - B.Z));
        }

        /*public static Point3D FindNear(Point3D[] where, Point3D refrence)
        {
            float dmin = Dist(where[0], refrence);
            Point3D toReturn = where[0];
            for (int i = 1; i < where.Length; i++)
            {
                float distance = Dist(where[i], refrence);
                if(distance < dmin)
                {
                    dmin = distance;
                    toReturn = where[i];
                }
            }
            return toReturn;
        }*/
        public static Point3D FindNearest(Point3D[] where, Point3D refrence)
        {
            float dmin = (float)1e5;
            Point3D toReturn = Point3D.Empty;
            for (int i = 1; i < where.Length; i++)
            {
                if (!where[i].visited)
                {
                    float distance = Dist(where[i], refrence);
                    if (distance < dmin)
                    {
                        dmin = distance;
                        toReturn = where[i];
                    }
                }
            }
            return toReturn;
        }
    }
}
