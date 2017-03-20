using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace ArtistsViewer
{
    class Program
    {
        private static object oldAlbumsPrices;

        static void Main(string[] args)
        {
            var url = "../../../Catalogue.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            XmlNode rootNode = doc.DocumentElement;
            Hashtable artistsList = new Hashtable();
            ConsolePrinter printer = new ConsolePrinter();

            // Task 2 - Using DOM & HashTable (see HashTablePopulatorUsingDOM.cs)
            string nodeName = "artist";
            HashTablePopulator populator = new HashTablePopulator();
            populator.PopulateTable(nodeName, rootNode, artistsList);
            printer.PrintTable(artistsList);

            artistsList.Clear();

            // Task 3 - Using XPath (see HashTablePopulatorUsingXPath.cs)
            string xPathQueryArtists = "/catalogue/album/artist";
            HashTablePopulatorUsingXPath xPathPopulator = new HashTablePopulatorUsingXPath();
            xPathPopulator.PopulateTable(xPathQueryArtists, artistsList, rootNode);
            printer.PrintTable(artistsList);

            // Task 4 - Delete all albums with price > 20
            // BEWARE - if you uncomment the next lines, permanent changes to the .xml file and rootNode will be made

            //for (int i = 0; i < rootNode.ChildNodes.Count; i++)
            //{
            //    XmlNode node = rootNode.ChildNodes[i];
            //    decimal price = decimal.Parse(node["price"].InnerText);
            //    if (price > 20)
            //    {
            //        rootNode.RemoveChild(node);
            //        i -= 1;
            //    }
            //}
            // doc.Save(url);

            // Task 5 - Extract songs titles
            List<string> titlesList = new List<string>();

            using (XmlReader reader = XmlReader.Create(url))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "title"))
                    {
                        titlesList.Add(reader.ReadElementContentAsString());
                    }
                }
            }

            printer.PrintList(titlesList);

            // Task 6 - Song titles with XDocument and Linq
            XDocument document = XDocument.Load(url);
            var titles = from title in document.Descendants("title")
                         select title.Value;
            printer.PrintList(titles);

            // Task 7 Create XML from text file
            string[] lines = File.ReadAllLines(@"../../../Person.txt");

            XElement people = new XElement("people");
            for (int i = 0; i < lines.Length; i+=3)
            {
                XElement person =
                new XElement("person",
                new XElement("name", lines[i]),
                new XElement("address", lines[i+1]),
                new XElement("phoneNumber", lines[i + 2])
                );
                people.Add(person);
            }

            printer.PrintXElement(people);

            // Task 8 Create album.xml
            Dictionary<string, string> albumsDictionary = new Dictionary<string, string>();

            using (XmlReader reader = XmlReader.Create(url))
            {
                string album = null;
                string artist = null;

                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "name"))
                    {
                        album = reader.ReadElementContentAsString();
                    }
                    else if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "artist"))
                    {
                        artist = reader.ReadElementContentAsString();
                    }

                    if (!string.IsNullOrEmpty(artist) && !string.IsNullOrEmpty(album))
                    {
                        albumsDictionary.Add(album, artist);
                        album = null;
                        artist = null;
                    }
                }
            }
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "\t",
                NewLineOnAttributes = true
            };
            using (XmlWriter writer = XmlWriter.Create("../../../NewCatalogue.xml", xmlWriterSettings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                for (int i = 0; i < albumsDictionary.Count; i++)
                {
                    writer.WriteStartElement("album");
                    writer.WriteElementString("title", albumsDictionary.Keys.ElementAt(i));
                    writer.WriteElementString("artist", albumsDictionary.Values.ElementAt(i));
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            // Task 11 Prices from the albums from 5 years ago
            XmlNodeList albumsPriceList = rootNode.SelectNodes("/catalogue/album/price");
            XmlNodeList publishDates = rootNode.SelectNodes("/catalogue/album/year");
            XmlNodeList artists = rootNode.SelectNodes("/catalogue/album/artist");
            List< string> oldAlbumsPrices = new List<string>();
            var currentYear = DateTime.Today.Year;
            for (int i = 0; i < albumsPriceList.Count; i++)
            {
                if (int.Parse(publishDates[i].InnerText) < currentYear - 5)
                {
                    oldAlbumsPrices.Add(albumsPriceList[i].InnerText);
                }
            }
            printer.PrintList(oldAlbumsPrices);
            oldAlbumsPrices.Clear();

            // Task 12 Prices from albums from 5 years ago witn Linq
            var pricesFromOlderAlbums =
                from album in document.Descendants("album")
                where int.Parse(album.Element("year").Value) < currentYear - 5
                select album.Element("price").Value;

            printer.PrintList(pricesFromOlderAlbums);
            
            // Task 13 - StyleSheet.xslt 
        }
    }
}
