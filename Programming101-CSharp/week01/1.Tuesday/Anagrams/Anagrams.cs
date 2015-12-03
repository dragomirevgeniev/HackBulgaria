using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    public static class Anagrams
    {
        public static string anagramPart = string.Empty;

        public static bool IsAnagram(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2) || s1.Length != s2.Length)
            { 
                return false;
            }

            string first = s1.Replace(" ", string.Empty).ToUpper();
            string second = s2.Replace(" ", string.Empty).ToUpper();

            foreach (char c in second)
            {
                int index = first.IndexOf(c);
                if (index >= 0)
                {
                    first = first.Remove(index, 1);
                }

                else
                {
                    return false;
                }
            }

            return string.IsNullOrEmpty(first);
        }

        public static bool HasAnagramOf(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
            {
                return false;
            }

            List<string> parts = new List<string>();
            bool itHas = false;
            
            if (s1.Length >= s2.Length)
            {
                for (int i = 0; i < s1.Length - s2.Length; i++)
                {
                    parts.Add(s1.Substring(i, s2.Length));
                }

                for (int i = 0; i < parts.Count; i++)
                {
                    if (IsAnagram(s2, parts[i]))
                    {
                        itHas = true;
                        anagramPart = parts[i];
                    }
                }
            }

            else
            {
                for (int i = 0; i < s2.Length - s1.Length; i++)
			    {
                    parts.Add(s2.Substring(i, s1.Length));
			    }

                for (int i = 0; i < parts.Count; i++)
                {
                    if (IsAnagram(s1, parts[i]))
                    {
                        itHas = true;
                        anagramPart = parts[i];
                    }
                }
            }

            return itHas;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first string:");
            string first = Console.ReadLine();
            Console.WriteLine("Pelase enter the second string:");
            string second = Console.ReadLine();
            Console.WriteLine("\"{0}\" is anagram of \"{1}\" : {2}", first, second, IsAnagram(first, second));
            
            if (!IsAnagram(first, second))
            {
                Console.WriteLine("\"{0} has anagram of \"{1}\" : {2} - {3}", first, second, HasAnagramOf(first, second), anagramPart);
            }
        }
    }
}

