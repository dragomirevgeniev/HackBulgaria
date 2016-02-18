using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassArrayExtension
{
    static class ArrayExtension
    {
        private static readonly char ReplacingValue;

        // property for tests
        static public char GetReplacingValue { get { return ReplacingValue; } }

        static ArrayExtension()
        {
            ReplacingValue = new Configuration().GetReplacingValue();
        }
        
        public static List<T> Intersect<T>(this List<T> firstList, List<T> secondList) where T : IComparable
        {
            List<T> intersected = new List<T>();
            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i].CompareTo(secondList[j]) == 0)
                    {
                        intersected.Add(firstList[i]);
                    }
                }
            }

            return intersected;
        }

        public static List<T> UnionAll<T>(List<T> firstList, List<T> secondList) where T : IComparable
        {
            List<T> allUnioned = new List<T>();
            allUnioned.AddRange(firstList);
            allUnioned.AddRange(secondList);
            return allUnioned;
        }

        public static List<T> Union<T>(List<T> firstList, List<T> secondList) where T : IComparable
        {
            List<T> unioned = new List<T>();
            unioned = UnionAll(firstList, secondList);
            foreach (var item in firstList.Intersect(secondList))
            {
                unioned.Remove(item);
            }
            
            return unioned;
        }

        public static string Join(List<string> list)
        {
            StringBuilder joined = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                joined.Append(list[i]).Append(ReplacingValue);
            }

            return joined.ToString();
        }
    }
}
