using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InflateARectangle
{
    public class InflateARectangle
    {
        public static void Inflate(ref Rectangle rect, Size inflateSize)
        {
            Console.WriteLine("Inflating the rectangle...");
            rect.X -= inflateSize.Width;
            rect.Y -= inflateSize.Height;
            rect.Width += 2 * inflateSize.Width;
            rect.Height += 2 * inflateSize.Height;
        }
        
        public static void Main(string[] args)
        {
            Console.Write("Width: ");
            int newWidth = int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            int newHeight = int.Parse(Console.ReadLine());
            Size newSize = new Size(newWidth, newHeight);
            Rectangle rect = new Rectangle(0, 0, 10, 10);
            Inflate(ref rect, newSize);
            Console.WriteLine(rect);
        }
    }
}
