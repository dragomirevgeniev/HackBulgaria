using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalScalarProduct
{
    public class MaximalScalarProduct
    {
        public static int GetMaximalScalarProduct(List<int> v1, List<int> v2)
        {
            if (v1 == null || v2 == null || v1.Count != v2.Count)
            {
                return 0;
            }

            // Sorting the lists in order the get the maximal value for the product
            v1.Sort();
            v2.Sort();

            int maxProdcut = 0;
            for (int i = 0; i < v1.Count; i++)
            {
                maxProdcut += v1[i] * v2[i];
            }

            return maxProdcut;
        }
        
        
        public static void Main(string[] args)
        {
            List<int> vector1 = new List<int>() { -2, 1, -5, 4, 3, 12, 8, 4 };
            List<int> vector2 = new List<int>() { 3, -5, 16, 8, 1, -2, -4, 1 };

            Console.Write("The maximal scalar product of the vectors:\n( ");
            for (int i = 0; i < vector1.Count; i++)
            {
                Console.Write("{0} ", vector1[i]);
            }

            Console.Write(") and ( ");
            for (int i = 0; i < vector2.Count; i++)
            {
                Console.Write("{0} ", vector2[i]);
            }

            Console.WriteLine(") is: {0}", GetMaximalScalarProduct(vector1, vector2));
        }
    }
}
