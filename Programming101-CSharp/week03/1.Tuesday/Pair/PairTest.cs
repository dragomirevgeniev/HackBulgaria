using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair
{
    public class PairTest : Pair
    {
        public static void Main(string[] args)
        {
            Pair asd = new Pair(3, 4);
            Pair asdec = new Pair(3, 4);
            Pair qwe = new Pair(3, 5);
            Pair stringos = new Pair("str1", "str2");
            Pair ofPairs = new Pair(qwe, stringos);
            Console.WriteLine("{0} ; Hash code: {1}", asd, asd.GetHashCode());
            Console.WriteLine("{0} ; Hash code: {1}", qwe, qwe.GetHashCode());
            Console.WriteLine("{0} ; Hash code: {1}", stringos, stringos.GetHashCode());
            Console.WriteLine("{0} ; Hash code: {1}", ofPairs, ofPairs.GetHashCode());
            Console.WriteLine(asd == asdec);
            Console.WriteLine(asd.Equals(asdec));
            Console.WriteLine(qwe.Equals(asd));
        }
    }
}
