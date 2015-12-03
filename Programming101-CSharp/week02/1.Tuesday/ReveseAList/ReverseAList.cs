using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReveseAList
{
    public class ReverseAList
    {
        public static void ReverseList(List<int> list)
        {
            Console.WriteLine("Reversing list...");

            for (int i = 0; i < list.Count / 2; i++)
            {
                int temp = 0;
                temp = list[i];
                list[i] = list[list.Count - 1 - i];
                list[list.Count - 1 - i] = temp;
            }
        }
        
        public static void Main(string[] args)
        {
            Console.Write("Please enter N numbers to be added in a list:\nN: ");
            int size = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(size);
            for (int i = 0; i < size; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine();
            ReverseList(list);
            Console.WriteLine("Reversed: {0}", string.Join(", ", list));
        }
    }
}
