using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RandomNumbers
{
    public class RandomNumbers
    {
        public static void GenerateRandomMatrix(int rows, int columns, string fileName)
        {
            string[] contents = new string[rows];
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                contents[i] = "";
                for (int j = 0; j < columns; j++)
                {
                    float randFloat = (float)(rand.NextDouble() * 1000);
                    contents[i] += string.Format("{0,8:F2}", randFloat);
                }
            }

            try
            {
                File.WriteAllLines(fileName, contents);
                Console.WriteLine("{0} has been written successfuly.", fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Creating a matrix of random floating point numbers with:");
            Console.Write("-number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("-number of columns: ");
            int cols = int.Parse(Console.ReadLine());
            GenerateRandomMatrix(rows, cols, "randomNumbersMatrix.txt");
        }
    }
}