using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInAList
{
    public class SearchInAList
    {
        public static bool TryFindSubstring(List<string> list, string searched, out int foundIndex)
        {
            foundIndex = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(searched))
                {
                    foundIndex = i;
                    return true;
                }
            }

            return false;
        }
        
        public static void Main(string[] args)
        {
            List<string> list = new List<string>(){"haba", "babba", "asd", "sasho", "rekt"};
            Console.Write("Please enter the searched word: ");
            string searchedWord = Console.ReadLine();
            int foundIndex;
            if (!TryFindSubstring(list, searchedWord, out foundIndex))
            {
                Console.WriteLine("Did not find the word.");
            }

            else
            {
                Console.WriteLine("Searched word found: {0} with list index: {1}.", TryFindSubstring(list, searchedWord, out foundIndex), foundIndex);
            }
        }
    }
}
