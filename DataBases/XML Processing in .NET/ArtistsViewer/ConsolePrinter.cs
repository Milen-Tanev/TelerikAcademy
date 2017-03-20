using System;
using System.Collections;
using System.Xml.Linq;

namespace ArtistsViewer
{
    internal class ConsolePrinter
    {
        internal ConsolePrinter()
        {

        }

        internal void PrintTable(IEnumerable table)
        {
            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine("{0} - {1}", entry.Key, entry.Value);
            }
            Console.WriteLine("------------------------");
        }

        internal void PrintList(IEnumerable list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
        }

        internal void PrintXElement(XElement xmlToPrint)
        {
            Console.WriteLine(xmlToPrint);
            Console.WriteLine("------------------------");
        }

        internal void PrintList(object years)
        {
            throw new NotImplementedException();
        }
    }
}
