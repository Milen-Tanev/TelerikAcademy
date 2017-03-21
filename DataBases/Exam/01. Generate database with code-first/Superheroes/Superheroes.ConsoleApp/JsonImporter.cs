namespace Superheroes.ConsoleApp
{
    using System.IO;

    public class JsonImporter
    {
        private const string Url = "../../../../../02. Json-Data/sample-data.json";

        public string LoadJson()
        {
            string json;
            using (StreamReader r = new StreamReader(Url))
            {
                json = r.ReadToEnd();
            }
            return json;
        }
    }
}
