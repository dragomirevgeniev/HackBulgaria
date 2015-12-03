using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ApplyingLinearFilterToAnImage
{
    public class BlurringAnImage
    {
        public static void BlurImage(Bitmap bitmap, string savePath)
        {
            Bitmap blurred = new Bitmap(bitmap.Width, bitmap.Height);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    int newRed = 0;
                    int newGreen = 0;
                    int newBlue = 0;
                    int count = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (x + i > 0 && x + i < (bitmap.Width - 1) && y + j > 0 && y + j < (bitmap.Height - 1))
                            {
                                Color currPixel = bitmap.GetPixel(x + i, y + j);
                                newRed += currPixel.R;
                                newGreen += currPixel.G;
                                newBlue += currPixel.B;
                                count++;
                            }
                        }
                    }

                    newRed = (int)Math.Round((double)newRed / count);
                    newGreen = (int)Math.Round((double)newGreen / count);
                    newBlue = (int)Math.Round((double)newBlue / count);
                    blurred.SetPixel(x, y, Color.FromArgb(newRed, newGreen, newBlue));
                }
            }
            
            blurred.Save(savePath);
        }
        
        public static void Main(string[] args)
        {
            Bitmap inputImage = (Bitmap)Image.FromFile("parrots.bmp");
            Console.WriteLine("Blurring image...");
            BlurImage(inputImage, "blurredImage.bmp");
            Console.WriteLine("A blurred image was created.");
        }
    }
}
