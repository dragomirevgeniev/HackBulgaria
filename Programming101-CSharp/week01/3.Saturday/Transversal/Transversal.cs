using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transversal
{
    public class Transversal
    {
        public static bool IsTransversal(List<int> transversal, List<List<int>> family)
        {
            if (transversal.Count < family.Count)
            {
                return false;
            }

            List<int> transversalCopy = new List<int>(transversal.Count);

            foreach (var item in transversal)
            {
                transversalCopy.Add(item);
            }

            for (int i = 0; i < family.Count; i++)
            {
                for (int j = 0; j < family[i].Count; j++)
                {
                    if (transversal.Contains(family[i][j]))
                    {
                        transversalCopy.Remove(family[i][j]);
                        break;
                    }
                }
            }

            return (transversalCopy.Count == transversal.Count - family.Count);
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine(IsTransversal(new List<int>{4, 5, 6}, 
                new List<List<int>>{new List<int>{5, 7, 9}, new List<int>{1, 4, 3}, new List<int>{2, 6}}));
            Console.WriteLine(IsTransversal(new List<int>{1, 2}, 
                new List<List<int>>{new List<int>{1, 5}, new List<int>{2, 3}, new List<int>{4, 7}}));
            Console.WriteLine(IsTransversal(new List<int>{2, 3, 4}, 
                new List<List<int>>{new List<int>{1, 7}, new List<int>{2, 3, 5}, new List<int>{4, 8}}));
        }
    }
}
