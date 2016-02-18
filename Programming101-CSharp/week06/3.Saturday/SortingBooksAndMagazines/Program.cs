using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingBooksAndMagazines
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("Harry Potter", 1),
                new Book("Sasho in Wonderland", 2),
                new Book("The silence of the Dilyans", 3),
                new Book("Shrek", 12),
                new Book("Dido Peevski", 69),
                new Book("Red, green, blue", 13),
                new Book("Arnold", 80),
                new Book("Texas Chainsaw", 19),
                new Book("Ani is guilty", 55)
            };

            List<Magazine> magazines = new List<Magazine>()
            {
                new Magazine("Treta vuzrast", 123),
                new Magazine("Cosmopolitan", 12),
                new Magazine("Sasho shop", 15),
                new Magazine("Perfect girls", 69),
                new Magazine("24 hours", 365),
                new Magazine("Tarator", 19)
            };

            List<string> sorted = new List<string>();
            sorted = MagazineAndBookSorter.Sort(books, magazines);
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
