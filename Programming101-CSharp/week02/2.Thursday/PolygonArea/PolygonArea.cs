using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonArea
{
    public class PolygonArea
    {
        public static float CalcArea(PointF[] points)
        {
            if (points.Length < 3)
            {
                throw new ArgumentException();
            }

            float area = 0;
            PointF first = points[0];
            PointF last = points[0];

            for (int i = 1; i < points.Length; i++)
            {
                area += last.X * points[i].Y - last.Y * points[i].X;
                last = points[i];
            }

            area += last.X * first.Y - last.Y * first.X;

            return Math.Abs(area / 2);
        }

        public static void Main(string[] args)
        {
            PointF[] polygonPoints = new PointF[] {
                new PointF((float)0, (float)0),
                new PointF((float)4, (float)0),
                new PointF((float)4, (float)4),
                new PointF((float)0, (float)4)
            };

            Console.WriteLine("{0:N3}", CalcArea(polygonPoints));
        }
    }
}

