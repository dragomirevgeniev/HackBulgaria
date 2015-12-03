using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningStrings
{
    public class JoiningStrings
    {
        public static string JoinStrings(string separator, params string[] strings)
        {
            StringBuilder joinedStrings = new StringBuilder();

            for (int i = 0; i < strings.Length; i++)
            {
                joinedStrings.Append(strings[i]);
                joinedStrings.Append(separator);
            }

            joinedStrings.Remove(joinedStrings.Length - separator.Length, separator.Length);
            return joinedStrings.ToString();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Joined with separator: {0}", JoinStrings("|", "asd", "123", "124s", "123sav", "eeE12S"));
        }
    }
}
