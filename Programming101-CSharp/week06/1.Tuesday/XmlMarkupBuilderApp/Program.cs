using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlMarkupBuilderLibrary;

namespace XmlMarkupBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlMarkupBuilder markupBuilder = new XmlMarkupBuilder();
            markupBuilder.OpenTag("Author").AddAttr("name", "Pesho")
                .OpenTag("Book").AddAttr("id", "1").AddAttr("year", "1978")
                .AddText("Book about Cooking")
                .CloseTag()
                .OpenTag("Book").AddAttr("id", "2").AddAttr("year", "2006")
                .AddText("Ala Bala")
                .CloseTag()
                .CloseTag()
                .Finalize();

            Console.WriteLine(markupBuilder.GetResult());
        }
    }
}
