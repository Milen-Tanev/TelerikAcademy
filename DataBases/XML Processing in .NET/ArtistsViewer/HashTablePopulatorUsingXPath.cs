using System.Collections;
using System.Xml;

namespace ArtistsViewer
{
    internal class HashTablePopulatorUsingXPath
    {
        internal HashTablePopulatorUsingXPath()
        {
        }

        internal void PopulateTable(string key, Hashtable table, XmlNode rootNode)
        {
            XmlNodeList keys = rootNode.SelectNodes(key);

            for (int i = 0; i < keys.Count; i++)
            {
                int tableValue = 1;
                if (table.ContainsKey(keys[i].InnerText))
                {
                    table[keys[i].InnerText] = (int)table[keys[i].InnerText] + 1;
                }
                else
                {
                    table.Add(keys[i].InnerText, tableValue);
                }
            }
        }
    }
}