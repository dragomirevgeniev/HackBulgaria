using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrayscaleImage
{
    public class GrayscaleImage
    {
        public static void GreyScaleImage(Bitmap bitmap, string savePath)
        {
            Bitmap greyImage = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color oldColor = bitmap.GetPixel(i, j);
                    int grayScale = (int)((oldColor.R * 0.3) + (oldColor.G * 0.59) + (oldColor.B * 0.11));
                    Color newColor = Color.FromArgb(oldColor.A, grayScale, grayScale, grayScale);
                    greyImage.SetPixel(i, j, newColor);
                }
            }

            greyImage.Save(savePath);
        }
        
        public static void Main(string[] args)
        {
            Bitmap inputImage = (Bitmap)Image.FromFile("parrots.bmp");
            GreyScaleImage(inputImage, "greyImage.bmp");
            Console.WriteLine("A greyscale image was created.");
        }
    }
}
