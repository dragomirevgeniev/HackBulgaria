using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonCircumference
{
    public class PolygonCircumference
    {
        public static float CalcCircumference(PointF[] points)
        {
            if (points.Length < 3)
            {
                throw new ArgumentException();
            }

            float perimeter = 0;
            PointF first = points[0];
            PointF last = points[0];

            for (int i = 1; i < points.Length; i++)
            {
                perimeter += (float)Math.Sqrt(Math.Pow(points[i].X - last.X, 2) + Math.Pow(points[i].Y - last.Y, 2));
                last = points[i];
            }

            return perimeter += (float)Math.Sqrt(Math.Pow(first.X - last.X, 2) + Math.Pow(first.Y - last.Y, 2));
        }

        public static void Main(string[] args)
        {
            PointF[] polygonPoints = new PointF[] {
                new PointF((float)0.2, (float)2.35),
                new PointF((float)1.2, (float)2.35),
                new PointF((float)2.2, (float)2.35),
                new PointF((float)3.2, (float)2.35),
                new PointF((float)4.2, (float)2.35),
                new PointF((float)5.2, (float)2.35),
                new PointF((float)6.2, (float)2.35)
            };

            Console.WriteLine(CalcCircumference(polygonPoints));
        }
    }
}
