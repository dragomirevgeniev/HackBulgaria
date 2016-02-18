using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingBooksAndMagazines
{
    public static class MagazineAndBookSorter
    {
        private class Edition
        {
            public string EditionName { get; set; }
            public int Order { get; set; }

            public Edition(Book book)
            {
                this.EditionName = book.Name;
                this.Order = book.ID;
            }

            public Edition(Magazine magazine)
            {
                this.EditionName = magazine.Title;
                this.Order = magazine.ISBN;
            }
        }
        
        public static List<string> Sort(List<Book> books, List<Magazine> magazines)
        {
            List<Edition> editions = new List<Edition>();
            foreach (var book in books)
            {
                editions.Add(new Edition(book));
            }

            foreach (var magazine in magazines)
            {
                editions.Add(new Edition(magazine));
            }

            var sortedEditions = from edition in editions
                                 orderby edition.EditionName, edition.Order
                                 select edition.EditionName;

            return sortedEditions.ToList();
        }
    }
}
