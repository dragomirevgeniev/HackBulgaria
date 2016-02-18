using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinkedList;

namespace LinkedListTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new LinkedList.LinkedList<string>();
            list.Add("x");
            list.Add("g");
            list.Add("s");

            Console.WriteLine(list.Count); //output: 3

            list.InsertAfter("g", "a");
            list.InsertAt(10, "z"); //throws an exception - IndexOutOfRangeException
            list.InsertAt(2, "z");
            list.Remove("z");
            list[1] = "m";

            foreach (string value in list)
            {
                Console.WriteLine(value);
            }
            //output:
            //x
            //m
            //a
            //s
        }
    }
}
