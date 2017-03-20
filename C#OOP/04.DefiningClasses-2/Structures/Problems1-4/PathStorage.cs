namespace Structures
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Collections;
    public static class PathStorage
    {
        public static void Save(Path path, string fileName)
        {
            string fullFilePath = File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
            using (StreamWriter writer = File.CreateText(fullFilePath))
            {
                writer.Write(path.ToString());
            }
        }

        
    }
}
