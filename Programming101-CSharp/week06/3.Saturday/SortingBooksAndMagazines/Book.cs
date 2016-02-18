using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingBooksAndMagazines
{
    public class Book
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Book(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}
