using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingBooksAndMagazines
{
    public class Magazine
    {
        public string Title { get; set; }
        public int ISBN { get; set; }

        public Magazine(string title, int isbn)
        {
            Title = title;
            ISBN = isbn;
        }
    }
}
