using System.Collections;
using System.Xml;

namespace ArtistsViewer
{
    internal class HashTablePopulator
    {
        internal HashTablePopulator()
        {
        }

        internal void PopulateTable(string nodeName, XmlNode rootElement, Hashtable table)
        {
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                // artist name is the key of the hashtable
                string key = node[nodeName].InnerText;
                int value = 1;
                if (table.ContainsKey(key))
                {
                    table[key] = (int)table[key] + 1;
                }
                else
                {
                    table.Add(node["artist"].InnerText, (int)value);
                }
            }
        }
    }
}
