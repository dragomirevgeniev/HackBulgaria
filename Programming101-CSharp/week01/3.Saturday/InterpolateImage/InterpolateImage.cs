using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InterpolateImage
{
    public class InterpolateImage
    {
        public static void ResampleImage(Bitmap bitmap, Size newSize, string savePath)
        {
            Bitmap resized = new Bitmap(newSize.Width, newSize.Height);

            double widthRatio = (double)(bitmap.Width - 1) / (resized.Width - 1);      
            double heightRatio = (double)(bitmap.Height - 1) / (resized.Height - 1);
            
            int i, j;
            for (i = 0; i < resized.Width; i++)
            {
                for (j = 0; j < resized.Height; j++)
                {
                    int oldX = (int)Math.Round(i * widthRatio);
                    int oldY = (int)Math.Round(j * heightRatio);
                    resized.SetPixel(i, j, bitmap.GetPixel(oldX, oldY));
                }
            }

            resized.Save(savePath);
        }
        
        public static void Main(string[] args)
        {
            Bitmap inputImage = (Bitmap)Image.FromFile("parrots.bmp");
            Console.WriteLine("Image current width: {0}", inputImage.Width);
            Console.WriteLine("Image current height: {0}", inputImage.Height);
            Console.Write("New width: ");
            int newWidth = int.Parse(Console.ReadLine());
            Console.Write("New height: ");
            int newHeight = int.Parse(Console.ReadLine());
            ResampleImage(inputImage, new Size(newWidth, newHeight), "resizedImage.bmp");
            Console.WriteLine("A resized image was created.");
        }
    }
}
