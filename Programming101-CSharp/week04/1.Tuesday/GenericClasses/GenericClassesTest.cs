using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class GenericClassesTest
    {
        public static void Main(string[] args)
        {
            GenericPair<int, string> pairche = new GenericPair<int, string>(5, "asd");
            GenericPair<int, string> pairche2 = new GenericPair<int, string>(5, "asd");
            Console.WriteLine("{0} equals {1} : {2}\n", pairche, pairche2, pairche.Equals(pairche2));

            GenericStack<int> stackche = new GenericStack<int>();
            stackche.Push(1);
            stackche.Push(2);
            stackche.Push(3);
            stackche.Push(4);
            Console.WriteLine(stackche.Peek());  // 4
            Console.WriteLine(stackche.Pop());   // 4
            Console.WriteLine(stackche.Peek());  // 3
            Console.WriteLine("The stack contains 2 : {0}", stackche.Contains(2));
            Console.WriteLine("The stack contains 7 : {0}", stackche.Contains(7));
            stackche.Clear();
            Console.WriteLine("Stack was cleared.");
            Console.WriteLine("The stack contains 2 : {0}\n", stackche.Contains(2));
            //Console.WriteLine(stackche.Peek()); // throws InvalidOperationException;

            GenericDequeue<int> dequeueche = new GenericDequeue<int>();
            dequeueche.AddToEnd(3);     // {3}
            dequeueche.AddToEnd(2);     // {3, 2}
            dequeueche.AddToFront(4);   // {4, 3, 2}
            dequeueche.AddToEnd(1);     // {4, 3, 2, 1}
            dequeueche.AddToFront(5);   // {5, 4, 3, 2, 1}
            Console.WriteLine(dequeueche.PeekFromEnd());   // 1
            Console.WriteLine(dequeueche.PeekFromFront()); // 5
            Console.WriteLine("Dequeue contains 5: {0}", dequeueche.Contains(5));
            dequeueche.RemoveFromEnd();   // {5, 4, 3, 2}
            dequeueche.RemoveFromFront(); // {4, 3, 2}
            Console.WriteLine("Dequeue contains 5: {0}", dequeueche.Contains(5));
            Console.WriteLine(dequeueche.PeekFromEnd());   // 2
            Console.WriteLine(dequeueche.PeekFromFront()); // 4
            dequeueche.Clear();
            //Console.WriteLine(dequeuche.PeekFromEnd()); // throws InvalidOperationException;
        }
    }
}
